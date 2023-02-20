using System.Xml.Serialization;

namespace Forms.Engine
{
    [Serializable]
    public class KeysConfig
    {
        public Keys KeyUp { get; set; }
        public Keys KeyDown { get; set; }
        public Keys KeyLeft { get; set; }
        public Keys KeyRight { get; set; }

        public Keys KeyMagic1 { get; set; }
        public Keys KeyMagic2 { get; set; }
        public Keys KeyMagic3 { get; set; }
        public Keys KeyMagic4 { get; set; }
        public Keys KeyMagic5 { get; set; }
        public Keys KeyMagic6 { get; set; }

        public Keys KeyArtefact1 { get; set; }
        public Keys KeyArtefact2 { get; set; }
        public Keys KeyArtefact3 { get; set; }
        public Keys KeyArtefact4 { get; set; }
        public Keys KeyArtefact5 { get; set; }
        public Keys KeyArtefact6 { get; set; }

        public Keys KeyInventory { get; set; }

        public KeysConfig() {}

        public KeysConfig(Keys keyUp, Keys keyDown, Keys keyLeft, Keys keyRight, Keys keyMagic1, Keys keyMagic2, Keys keyMagic3, Keys keyMagic4, Keys keyMagic5, Keys keyMagic6, Keys keyArtefact1, Keys keyArtefact2, Keys keyArtefact3, Keys keyArtefact4, Keys keyArtefact5, Keys keyArtefact6, Keys keyInventory)
        {
            KeyUp = keyUp;
            KeyDown = keyDown;
            KeyLeft = keyLeft;
            KeyRight = keyRight;
            KeyMagic1 = keyMagic1;
            KeyMagic2 = keyMagic2;
            KeyMagic3 = keyMagic3;
            KeyMagic4 = keyMagic4;
            KeyMagic5 = keyMagic5;
            KeyMagic6 = keyMagic6;
            KeyArtefact1 = keyArtefact1;
            KeyArtefact2 = keyArtefact2;
            KeyArtefact3 = keyArtefact3;
            KeyArtefact4 = keyArtefact4;
            KeyArtefact5 = keyArtefact5;
            KeyArtefact6 = keyArtefact6;
            KeyInventory = keyInventory;
        }

        public void SaveConfig()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(KeysConfig));
            using (FileStream fileStream = new FileStream("Data\\KeysConfig.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, this);
            }
        }

        public static KeysConfig LoadConfig()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(KeysConfig));
            using (FileStream fs = new FileStream("Data\\KeysConfig.xml", FileMode.OpenOrCreate))
            {
                return xmlSerializer.Deserialize(fs) as KeysConfig;
            }
        }
        public static void RestartConfig()
        {
            KeysConfig config;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(KeysConfig));
            using (FileStream fs = new FileStream("Data\\DefaultKeysConfig.xml", FileMode.OpenOrCreate))
            {
                config = xmlSerializer.Deserialize(fs) as KeysConfig;
            }
            using (FileStream fileStream = new FileStream("Data\\KeysConfig.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, config);
            }
        }
    }
}