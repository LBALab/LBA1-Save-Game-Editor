﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace LBA.Items
{
    class Items
    {
        public Item[] Inventory;
        public Item[] InventoryUsed;
        public Item[] Twinsen;
        public Item[] Quest;
        public Item[] Movies;
        public Item[] Holomap;
        public Item[] Areacode;
        public Item[] LBA1Skins;
        public Item MagicLevel;
        public Item MagicPoints;
        public Item Kashers;
        public Item Keys;
        public Item Clovers;
        public Item CloverBoxes;
        public Item Gas;
        public Item Health;
        public Item MecaPenguins;
        public Item Darts;
        public Item Gems;
        public Item Zilitos;
        private string LBAFilesPath;

        public Items(string LBAFilesPath, ushort LBAVer)
        {
            XmlDocument doc = new XmlDocument();
            string fileName;
            this.LBAFilesPath = LBAFilesPath;
            //fileName = "MemoryLocations.xml";
            
            //Inventory = loadItems(LBAVer, fileName, "/items/inventory/item");
            
            doc.Load(LBAFilesPath + "Twinsen.xml");
            loadTwinsen(LBAVer, doc.DocumentElement.SelectNodes("/Twinsen/item"));
            Twinsen = loadItems(LBAVer, "Twinsen.xml", "/Twinsen/item");
            Inventory = loadItems(LBAVer, "Inventory.xml", "/inventory/item");

            if (1 == LBAVer)
            {
                InventoryUsed = loadItems(LBAVer, "InventoryUsed.xml", "/inventoryUsed/item");
                Quest = loadItems(LBAVer, "QuestOffsets.xml", "/quests/item");
                Movies = loadItems(LBAVer, "MovieOffsets.xml", "/movies/item");
                Holomap = loadItems(LBAVer, "Holomap.xml", "/holomap/item");
                Areacode = loadItems(LBAVer, "Areacode.xml", "/areacode/item");
            }
        }

        //Assumes all files are in .\files\ folder
        private Item[] loadItems(ushort LBAVer, string fileName, string XMLQueryString)
        {
            bool areacode = XMLQueryString.Contains("areacode");
            string filePath = LBAFilesPath + fileName;
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList nodes = doc.DocumentElement.SelectNodes(XMLQueryString);
            Item[] items = new Item[nodes.Count];
            for (int i = 0; i < items.Length; i++)
                items[i] = getItem(nodes[i], areacode);
            return items;
        }

        private Item getItem(XmlNode xn, bool areaCode = false)
        {
            Item item = new Item();

            item.name = xn.SelectSingleNode("name").InnerText.Trim();
            string s = xn.SelectSingleNode("memoryOffset").InnerText.Trim();
            item.memoryOffset = uint.Parse(s, System.Globalization.NumberStyles.HexNumber);
            item.maxVal = ushort.Parse(xn.SelectSingleNode("maxVal").InnerText.Trim());
            item.minVal = ushort.Parse(xn.SelectSingleNode("minVal").InnerText.Trim());

            s = xn.SelectSingleNode("firstObtainableChapter").InnerText;
            if(0 < s.Length) 
                item.firstObtainableChapter = short.Parse(s.Trim());

            s = xn.SelectSingleNode("mustHaveForChapter").InnerText;
            if (0 < s.Length)
                item.mustHaveForChapter = short.Parse(s.Trim());

            s = xn.SelectSingleNode("mustLoseByChapter").InnerText;
            if (0 < s.Length)
                item.mustLoseByChapter = short.Parse(s.Trim());

            if (areaCode)
            {
                item.position.horizontal = ushort.Parse(xn.SelectSingleNode("position/horizontal").InnerText.Trim());
                item.position.vertical = ushort.Parse(xn.SelectSingleNode("position/vertical").InnerText.Trim());
                item.position.height = ushort.Parse(xn.SelectSingleNode("position/height").InnerText.Trim());
                item.position.facing = ushort.Parse(xn.SelectSingleNode("position/facing").InnerText.Trim());
            }
            item.size = ushort.Parse(xn.SelectSingleNode("size").InnerText.Trim());
            item.type = ushort.Parse(xn.SelectSingleNode("type").InnerText.Trim());
            item.lbaVersion = byte.Parse(xn.SelectSingleNode("lbaVersion").InnerText.Trim());
            return item;
        }

        private void loadTwinsen(ushort LBAVer, XmlNodeList nodes)
        {
            if (1 == LBAVer)
                loadLBA1Twinsen(nodes);
            else
                loadLBA2Twinsen(nodes);
        }

        private void loadLBA1Twinsen(XmlNodeList nodes)
        {
            MagicLevel = getItem(nodes[0]);
            MagicPoints = getItem(nodes[1]);
            Kashers = getItem(nodes[2]);
            Keys = getItem(nodes[3]);
            Clovers = getItem(nodes[4]);
            CloverBoxes = getItem(nodes[5]);
            Gas = getItem(nodes[6]);
            Health = getItem(nodes[7]);
        }

        private void loadLBA2Twinsen(XmlNodeList nodes)
        {
            MagicLevel = getItem(nodes[0]);
            MagicPoints = getItem(nodes[1]);
            Kashers = getItem(nodes[2]);
            Keys = getItem(nodes[3]);
            Clovers = getItem(nodes[4]);
            CloverBoxes = getItem(nodes[5]);
            Health = getItem(nodes[6]);
            MecaPenguins = getItem(nodes[7]);
            Darts = getItem(nodes[8]);
            Gems = getItem(nodes[9]);
            Zilitos = getItem(nodes[10]);
        }
    }
}
