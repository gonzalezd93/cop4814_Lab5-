using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace GameLib2
{
    public class GameFactory
    {
        public List<Game> games;

        public List<Game> dsgames;

        public string filepath;

        StreamWriter sw;

        StreamReader sr;

        XmlSerializer serial;

        public void CreateGameList()
        {
            games = new List<Game>();
            Game one = new Game("Heat", "Celtic", 89, 70);
            games.Add(one);
            one = new Game("Hawks", "Clippers", 75, 99);
            games.Add(one);
            one = new Game("Lakers", "Spurs", 90, 90);
            games.Add(one);
            one = new Game("Magic", "Rockets", 85, 112);
            games.Add(one);
            one = new Game("Pelicans", "Kings", 55, 70);
            games.Add(one);
            one = new Game("Thunder", "Warriors", 110, 115);
            games.Add(one);


        }

        public Boolean SerializeGameList()
        {

            sw = new StreamWriter(filepath);
            serial = new XmlSerializer(games.GetType());
            serial.Serialize(sw, games);
            sw.Close();
            return true;
        }

        public List<Game> DesirealizeGameList()
        {
            dsgames = new List<Game>();
            sr = new StreamReader(filepath);
            serial = new XmlSerializer(dsgames.GetType());
            dsgames = (List<Game>)serial.Deserialize(sr);
            sr.Close();


            return dsgames;


           
        }
            
    }
}
