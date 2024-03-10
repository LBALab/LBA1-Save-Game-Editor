using LBATrainer;
using System.Reflection;
using System.Text;
using LBA.Items;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Media;

namespace LBA1_Save_Game_Editor
{
    public partial class LBA1SavegameEditor : Form
    {
        string filePath;
        string fileName;
        private Items items;
        DateTime fileLastModified;
        public LBA1SavegameEditor()
        {
            InitializeComponent();
            SetDoubleBuffered(tcMain);
            items = new Items(getLBAFilesPath(1), 1);
            lblInfo.Visible = false;
            newgame();
        }
        private string getLBAFilesPath(ushort LBAVer)
        {
            return AppDomain.CurrentDomain.BaseDirectory + "files\\languages\\ENG\\lba" + LBAVer.ToString() + "\\";
        }
        public static void SetDoubleBuffered(Control control)
        {
            // set instance non-public property with name "DoubleBuffered" to true
            typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, control, new object[] { true });
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "lba";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "LBA Save files (*.lba)|*.lba|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            //No file selected
            if ("" == openFileDialog1.FileName) return;
            fileName = Path.GetFileName(openFileDialog1.FileName);
            processFile(openFileDialog1.FileName);
            filePath = Path.GetDirectoryName(openFileDialog1.FileName);
        }

        private void populateCheckList(CheckedListBox clb, Item[] items, bool zeroFill = false, byte[] data = null, char startPos = (char)0)
        {
            clb.Items.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                bool value = zeroFill ? false : 1 == data[startPos + i];
                clb.Items.Add(items[i].ToString(), value);
                items[i].maxVal = (ushort)(value ? 1 : 0);
            }
            clb.Tag = items;
        }


        private void processFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            char filePosition = (char)1;
            //If File doesn't exist or can't access
            if (!File.Exists(filePath))
            {
                SetInfoMessage("File either doesn't exist or can't access");
                return;
            }
            fileLastModified = fileInfo.LastWriteTimeUtc;
            txtPhysicalFileName.Text = Path.GetFileName(filePath);
            FileStream fs = File.OpenRead(filePath);
            byte[] fileBuffer = new byte[fileInfo.Length];
            fs.Read(fileBuffer, 0, fileBuffer.Length);
            fs.Close();
            chkReadOnly.Checked = fileInfo.IsReadOnly;
            cboFileFormatVersion.Text = fileBuffer[0].ToString("00");

            for (; 255 > filePosition && 0 != fileBuffer[filePosition]; filePosition++) ;
            if (255 == filePosition)
            {
                SetInfoMessage("Internal filename exceeded 255 character limit");
                return;
            }
            txtInternalFileName.Text = Encoding.UTF8.GetString(fileBuffer, 1, filePosition - 1);
            filePosition++;
            populateCheckList(clbInventory, items.Inventory, false, fileBuffer, (char)(filePosition + 0x01));
            populateCheckList(clbQuestFlag, items.Quest, false, fileBuffer, (char)(filePosition + 0x1D));
            populateCheckList(clbMovies, items.Movies, false, fileBuffer, (char)(filePosition + 0xC9));
            populateCheckList(clbInventoryUsed, items.InventoryUsed, false, fileBuffer, (char)(filePosition + 0x1AB));
            PopulateCBO(cboAreacode, items.Areacode, fileBuffer[filePosition + 0x100]);
            cboChapter.SelectedIndex = fileBuffer[filePosition + 0x101];
            cboBehaviour.SelectedIndex = fileBuffer[filePosition + 0x102];
            txtHealth.Text = fileBuffer[filePosition + 0x103].ToString();

            txtKashes.Text = reverseBytesToString(fileBuffer[filePosition + 0x104], fileBuffer[filePosition + 0x105]);

            txtMagicLevel.Text = fileBuffer[filePosition + 0x106].ToString();
            txtMagicPoints.Text = fileBuffer[filePosition + 0x107].ToString();
            txtCloverBox.Text = fileBuffer[filePosition + 0x108].ToString();

            txtHorizontalPos.Text = reverseBytesToString(fileBuffer[filePosition + 0x109], fileBuffer[filePosition + 0x10A]);
            txtHeight.Text = reverseBytesToString(fileBuffer[filePosition + 0x10B], fileBuffer[filePosition + 0x10C]);
            txtVerticalPos.Text = reverseBytesToString(fileBuffer[filePosition + 0x10D], fileBuffer[filePosition + 0x10E]);
            txtFacing.Text = reverseBytesToString(fileBuffer[filePosition + 0x10F], fileBuffer[filePosition + 0x110]);

            cboOutfit.SelectedIndex = fileBuffer[filePosition + 0x111];

            //Skipped holomap
            processHolomap(fileBuffer, filePosition + 0x113);

            txtGas.Text = fileBuffer[filePosition + 0x1A9].ToString();
            txtClovers.Text = fileBuffer[filePosition + 0x1C7].ToString();
            cboSelectedWeapon.SelectedIndex = fileBuffer[filePosition + 0x1C8];

        }

        private void processHolomap(byte[] data, int startPos)
        {
            PopulateCBO(cboHolomap, items.Holomap);
            for (int i = 0; i < items.Holomap.Length; i++)
            {
                items.Holomap[i].maxVal = data[startPos + i];
            }
            cboHolomap.Tag = items.Holomap;
        }
        private string reverseBytesToString(byte byteOne, byte byteTwo)
        {
            return WordToString(reverseBytes(byteOne, byteTwo));
        }
        private char reverseBytes(byte byteOne, byte byteTwo)
        {
            return (char)(byteTwo << 8 | byteOne);
        }

        private string WordToString(char word)
        {
            return ((int)word).ToString();
        }
        private int getIndexFromAreacode(int areacode)
        {
            for (int i = 0; i < items.Areacode.Length; i++)
                if ((items.Areacode[i].memoryOffset & 0x00FF) == areacode)
                    return i;
            return 0;
        }
        private void PopulateCBO(ComboBox cb, Item[] items, byte selectedIndex = 0, bool isAreacode = false)
        {
            cb.Items.Clear();
            cb.Items.AddRange(items);
            cb.SelectedIndex = isAreacode ? getIndexFromAreacode(selectedIndex) : selectedIndex;
            cb.Tag = items;
        }


        private void filterCBO(ComboBox cb, Item[] itms)
        {
            //If not entering data i.e. empty field
            if (-1 != cb.SelectedIndex) return;

            cb.Items.Clear();
            for (int i = 0; i < itms.Length; i++)
                if (itms[i].name.ToLower().Contains(cb.Text.ToLower()))
                    cb.Items.Add(itms[i]);

            cb.SelectionStart = cb.Text.Length;
            cb.SelectionLength = 0;
        }

        private void filterComboBox(object sender, EventArgs e)
        {
            if (null == sender) return;
            ComboBox cb = sender as ComboBox;
            //Fires on populating before tag is populated
            if (null == cb.Tag) return;
            filterCBO((ComboBox)sender, (Item[])cb.Tag);
        }

        private void cboHolomap_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb;
            cb = (ComboBox)sender;
            if (null == cb.Tag) return;
            Item[] items = (Item[])cb.Tag;
            Item itm = items[cb.SelectedIndex];

            chkHoloBit1.Checked = 0 != (itm.maxVal & 0b00000001);
            chkHoloBit2.Checked = 0 != (itm.maxVal & 0b00000010);
            chkHoloBit3.Checked = 0 != (itm.maxVal & 0b00000100);
            chkHoloBit4.Checked = 0 != (itm.maxVal & 0b00001000);
            chkHoloBit5.Checked = 0 != (itm.maxVal & 0b00010000);
            chkHoloBit6.Checked = 0 != (itm.maxVal & 0b00100000);
            chkHoloBit7.Checked = 0 != (itm.maxVal & 0b01000000);
            chkHoloBit8.Checked = 0 != (itm.maxVal & 0b10000000);

            filterComboBox(sender, null);
        }


        private void newgame()
        {
            cboFileFormatVersion.Text = "03";
            txtPhysicalFileName.Text = "S1337.LBA";
            txtInternalFileName.Text = "Phreak";
            txtCloverBox.Text = "2";
            txtClovers.Text = "0";
            txtMagicLevel.Text = "1";
            txtMagicPoints.Text = "20";
            txtHealth.Text = "50";
            txtKashes.Text = "221";
            txtGas.Text = "40";
            populateCheckList(clbInventory, items.Inventory, true);
            populateCheckList(clbQuestFlag, items.Quest, true);
            populateCheckList(clbMovies, items.Movies, true);
            populateCheckList(clbInventoryUsed, items.InventoryUsed, true);
            PopulateCBO(cboAreacode, items.Areacode, 1, true);
            cboChapter.SelectedIndex = 1;
            cboBehaviour.SelectedIndex = 0;
            cboOutfit.SelectedIndex = 1;
            cboSelectedWeapon.SelectedIndex = 0;
            for (int i = 0; i < items.Holomap.Count(); i++) items.Holomap[i].maxVal = 0;
            PopulateCBO(cboHolomap, items.Holomap);
            txtHorizontalPos.Text = "18919";
            txtVerticalPos.Text = "7418";
            txtHeight.Text = "778";
            txtFacing.Text = "122";
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newgame();
        }

        private void savegame()
        {
            string fullFilePath;

            if (string.IsNullOrEmpty(txtPhysicalFileName.Text) || txtPhysicalFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                SetInfoMessage("Filename contains invalid characters or is empty");
                return;
            }
            //Path not set and didn't choose one
            if (!getSaveFilePath()) return;
            fullFilePath = filePath + "\\" + txtPhysicalFileName.Text;
            if (File.Exists(fullFilePath))
            {
                DialogResult dr = MessageBox.Show("File already exists, overwrite?", "Overwrite", MessageBoxButtons.YesNoCancel);
                //If they don't want to over write just quit.
                if (!dr.Equals(DialogResult.Yes)) return;
                FileInfo fi = new FileInfo(fullFilePath);
                if (fi.IsReadOnly) fi.IsReadOnly = false;
                fi.Refresh();
            }

            BinaryWriter bw = new BinaryWriter(File.Open(fullFilePath, FileMode.Create));
            bw.Write((byte)int.Parse(cboFileFormatVersion.Text));
            if ("" == txtInternalFileName.Text) txtInternalFileName.Text = "Phreak";
            int realFileStart = 2 + txtInternalFileName.Text.Length; //Allows for the terminating null and the byte at the start of file.
            WriteStringNullTerminate(bw, txtInternalFileName.Text);
            bw.Write((byte)0xFF);
            WriteItemsMaxValToFile(bw, (Item[])clbInventory.Tag);
            WriteItemsMaxValToFile(bw, (Item[])clbQuestFlag.Tag);

            //Seek to movies
            bw.Seek(0xC9 + realFileStart, SeekOrigin.Begin);
            WriteItemsMaxValToFile(bw, (Item[])clbMovies.Tag);

            bw.Seek(0x100 + realFileStart, SeekOrigin.Begin);
            bw.Write(getAreacodeFromDescription(cboAreacode.Text));
            bw.Write((byte)cboChapter.SelectedIndex);
            bw.Write((byte)cboBehaviour.SelectedIndex);
            bw.Write(byte.Parse(txtHealth.Text));
            //bw.Write(stringToCharWithReversedBytes(txtKashes.Text));
            writeReverseWord(bw, txtKashes.Text);
            bw.Write((byte)int.Parse(txtMagicLevel.Text));
            bw.Write((byte)int.Parse(txtMagicPoints.Text));
            bw.Write((byte)int.Parse(txtCloverBox.Text));
            writeReverseWord(bw, txtHorizontalPos.Text);
            writeReverseWord(bw, txtHeight.Text);
            writeReverseWord(bw, txtVerticalPos.Text);
            writeReverseWord(bw, txtFacing.Text);
            bw.Write((byte)cboOutfit.SelectedIndex);
            bw.Write((byte)0x96);
            WriteItemsMaxValToFile(bw, (Item[])cboHolomap.Tag);
            bw.Seek(0x1A9 + realFileStart, SeekOrigin.Begin);
            bw.Write((byte)int.Parse(txtGas.Text));
            bw.Write((byte)0x1C);
            WriteItemsMaxValToFile(bw, (Item[])clbInventoryUsed.Tag);
            bw.Write((byte)int.Parse(txtClovers.Text));
            bw.Write((byte)cboSelectedWeapon.SelectedIndex);
            bw.Write((byte)0x00);
            bw.Flush();
            bw.Close();
            new FileInfo(fullFilePath) { IsReadOnly = chkReadOnly.Checked }.Refresh();
        }

        private void WriteStringNullTerminate(BinaryWriter bw, string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bw.Write((byte)s[i]);
            }
            bw.Write('\0');
        }

        //This expects a string of a number representable in two bytes
        private void writeReverseWord(BinaryWriter bw, string s)
        {
            int i = int.Parse(s);
            bw.Write((byte)(i & 0xFF));
            bw.Write((byte)(i >> 8));
        }
        private char stringToCharWithReversedBytes(string s)
        {
            int i = int.Parse(s);
            char c, res;
            c = (char)i;
            res = (char)(c << (char)8);
            res ^= (char)(c >> 8);
            return res;
        }

        private byte getAreacodeFromDescription(string name)
        {
            Item[] items = (Item[])cboAreacode.Tag;
            for (int i = 0; i < items.Length; i++)
                if (name.ToLower().Equals(items[i].name.ToLower()))
                    return (byte)(items[i].memoryOffset & 0x00FF);
            return 0;
        }


        private void WriteItemsMaxValToFile(BinaryWriter bw, Item[] items)
        {
            for (int i = 0; i < items.Count(); i++)
                bw.Write((byte)items[i].maxVal);
        }
        private bool getSaveFilePath()
        {
            //Check filepath exists
            if (!Directory.Exists(filePath))
            {
                SetInfoMessage("Please select save location");
                FolderBrowserDialog fbd;
                do
                {
                    fbd = new FolderBrowserDialog();
                    fbd.ShowNewFolderButton = true;
                    DialogResult dr = fbd.ShowDialog(this);
                    if (dr == DialogResult.Cancel) return false;
                } while (!Directory.Exists(fbd.SelectedPath));
                filePath = fbd.SelectedPath;
            }
            return true;
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                savegame();
                SetInfoMessage("File saved successfully");
            }
            catch (Exception ex)
            {
                SetInfoMessage("Save failed with exception '" + ex.Message + "'");
            }
        }

        Timer tmrClearInfoMessage;
        private void SetInfoMessage(string message)
        {
            lblInfoText.Text = message;
            lblInfo.Visible = true;
            SystemSounds.Beep.Play();
            if (null == tmrClearInfoMessage)
            {
                tmrClearInfoMessage = new Timer();
                tmrClearInfoMessage.Tick += TmrClearInfoMessage_Tick;
                tmrClearInfoMessage.Interval = 10 * 1000; //Number of seconds 10
            }
            tmrClearInfoMessage.Start();
        }

        private void TmrClearInfoMessage_Tick(object sender, EventArgs e)
        {
            lblInfoText.Text = "";
            lblInfo.Visible = false;
        }

        private void txtInventoryFilter_TextChanged(object sender, EventArgs e)
        {
            clbInventory.Items.Clear();
            clbInventoryUsed.Items.Clear();
            for (int i = 0; i < items.Inventory.Count(); i++)
            {
                if (items.Inventory[i].name.ToLower().Contains(txtInventoryFilter.Text.ToLower()))
                {
                    clbInventory.Items.Add(items.Inventory[i], 1 == items.Inventory[i].maxVal);
                    clbInventoryUsed.Items.Add(items.InventoryUsed[i], 1 == items.InventoryUsed[i].maxVal);
                }
            }
        }

        private void txtQuestFilter_TextChanged(object sender, EventArgs e)
        {
            clbQuestFlag.Items.Clear();
            for (int i = 0; i < items.Quest.Count(); i++)
            {
                if (items.Quest[i].name.ToLower().Contains(txtQuestFilter.Text.ToLower()))
                {
                    clbQuestFlag.Items.Add(items.Quest[i], 1 == items.Quest[i].maxVal);
                }
            }
        }

        private void clb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            string itemName = clb.Items[e.Index].ToString();
            Item[] items = clb.Tag as Item[];
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i].name.ToLower() == itemName.ToLower())
                {
                    items[i].maxVal = (ushort)(CheckState.Checked == e.NewValue ? 1 : 0);
                    clb.Tag = items;
                    return;
                }
            }
        }

        private void changeSaveDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getSaveFilePath();
        }

        private void btnMaxBasic_Click(object sender, EventArgs e)
        {
            txtCloverBox.Text = items.CloverBoxes.maxVal.ToString();
            txtClovers.Text = items.Clovers.maxVal.ToString();
            txtMagicLevel.Text = items.MagicLevel.maxVal.ToString();
            txtMagicPoints.Text = items.MagicPoints.maxVal.ToString();
            txtHealth.Text = items.Health.maxVal.ToString();
            txtKashes.Text = items.Kashers.maxVal.ToString();
            txtGas.Text = items.Gas.maxVal.ToString();
        }

        private void btnMaxQuest_Click(object sender, EventArgs e)
        {
            CLBCheckAllItems(clbQuestFlag);
        }

        private void CLBCheckAllItems(CheckedListBox clb)
        {
            Item[] items = clb.Tag as Item[];
            for (int i = 0; i < items.Count(); i++)
                items[i].maxVal = 1;
            clb.Tag = items;
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, true);
            }
        }

        private void btnMaxInv_Click(object sender, EventArgs e)
        {
            CLBCheckAllItems(clbInventory);
        }
        private void btnMaxInvUsed_Click(object sender, EventArgs e)
        {
            CLBCheckAllItems(clbInventoryUsed);
        }
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ("" == filePath) return;
            processFile(filePath + "\\" + fileName);
        }
        private void LBA1SavegameEditor_Activated(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(filePath + "\\" + fileName);
            if (fi.LastWriteTimeUtc > fileLastModified && fileLastModified.Ticks != 0)
                if (DialogResult.Yes == MessageBox.Show("File has been modified, update?", "Reload?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    processFile(filePath + "\\" + fileName);
        }

        private void btnChapterMin_Click(object sender, EventArgs e)
        {
            byte chapter = (byte)cboSelectChapter.SelectedIndex;
            cboChapter.SelectedIndex = chapter;

            for (int i = 0; i < items.Inventory.Length; i++)
            {
                bool valid = isValidMinForChapter(items.Inventory[i], chapter);
                clbInventory.SetItemChecked(i, valid);
                clbInventoryUsed.SetItemChecked(i, valid);
            }

            for (int i = 0; i < items.Quest.Length; i++)
                clbQuestFlag.SetItemChecked(i, isValidMinForChapter(items.Quest[i], chapter));
            SetOutfitChapter(chapter, false);
        }
        private bool isValidMinForChapter(Item item, byte chapter)
        {
            //Item is never required
            if (-1 == item.mustHaveForChapter) return false;
            //If must have lost this item by this chapter i.e. can't have cherry syrup AND must lose by chapter isn't never
            if (item.mustLoseByChapter <= chapter && -1 != item.mustLoseByChapter) return false;
            if (item.mustHaveForChapter <= chapter) return true;
            return false;
        }
        private void btnChapterMax_Click(object sender, EventArgs e)
        {
            byte chapter = (byte)cboSelectChapter.SelectedIndex;
            cboChapter.SelectedIndex = chapter;

            for (int i = 0; i < items.Inventory.Length; i++)
            {
                bool valid = isValidMaxForChapter(items.Inventory[i], chapter);
                clbInventory.SetItemChecked(i, valid);
                clbInventoryUsed.SetItemChecked(i, valid);
            }

            for (int i = 0; i < items.Quest.Length; i++)
                clbQuestFlag.SetItemChecked(i, isValidMaxForChapter(items.Quest[i], chapter));
            SetOutfitChapter(chapter, true);
        }
        private bool isValidMaxForChapter(Item item, byte chapter)
        {
            if (item.mustLoseByChapter <= chapter && -1 != item.mustLoseByChapter) return false;
            if (item.firstObtainableChapter <= chapter) return true;
            return false;
        }
        private void SetOutfitChapter(byte chapter, bool max)
        {
            const byte TunicMedallion = 0;
            const byte Tunic = 1;
            const byte TunicMedallionSword = 2;
            const byte Prison = 3;
            const byte Nurse = 4;
            switch (chapter)
            {
                case 0:
                    {
                        if (max)
                            cboOutfit.SelectedIndex = Nurse;
                        else
                            cboOutfit.SelectedIndex = Prison;
                        break;
                    }

                case 1:
                case 2:
                    cboOutfit.SelectedIndex = Nurse;
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    cboOutfit.SelectedIndex = Tunic;
                    break;

                case 9:
                    if (max)
                        cboOutfit.SelectedIndex = TunicMedallion;
                    else
                        cboOutfit.SelectedIndex = Tunic;
                    break;


                default:
                    cboOutfit.SelectedIndex = TunicMedallion;
                    break;
            }
        }

        private void cboAreacode_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterComboBox(sender, e);
            ComboBox cbo = (ComboBox)sender;
            Item[] items = (Item[])cbo.Tag;
            if (null == items) return;
            byte index = (byte)getIndexFromAreacode(getAreacodeFromDescription(cbo.Text));
            txtHorizontalPos.Text = items[index].position.horizontal.ToString();
            txtVerticalPos.Text = items[index].position.vertical.ToString();
            txtFacing.Text = items[index].position.facing.ToString();
            txtHeight.Text = items[index].position.height.ToString();
        }

        private void txtPhysicalFileName_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPhysicalFileName.Text))
                fileName = txtPhysicalFileName.Text;
        }
    }
}