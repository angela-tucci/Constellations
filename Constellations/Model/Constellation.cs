using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellations.Model
{
    class Constellation
    {
        //fields
        private string _name; //name of constellation
        private string _abbreviation; //official 3 letter abbreviation (comes from its genitive form)
        private string _genitive; //other name?????
        private string _family; //what constellation family its in 
        //(constellations in a family share some characteristics, such as origin or mythology)
        private string _origin; //who discovered it
        private string _meaning; //translation from latin (usually)
        private string _brightestStar; //name of brightest star in the constellation
        private string _hemisphere; //what hemisphere its in
        private string _season; //season its visible
        private string _bestSeen; //time of year its best seen
        private string _nearbyConstellations; //nearby constellations
        private string _mythology; //brief mythological story behind it
        private string _imagePathSky; //natural image in the sky
        private string _imagePathStars; //image with just stars 
        private string _imagePathPicture; //image with mythology picture

        //properties
        public string Name
        {
            get { return _name; }
            set {
                _name = value;
            }
        }

        public string Abbreviation
        {
            get { return _abbreviation; }
            set
            {
                _abbreviation = value;
            }
        }

        public string Genitive
        {
            get { return _genitive; }
            set
            {
                _genitive = value;
            }
        }

        public string Family
        {
            get { return _family; }
            set
            {
                _family = value;
            }
        }

        public string Origin
        {
            get { return _origin; }
            set
            {
                _origin = value;
            }
        }

        public string Meaning
        {
            get { return _meaning; }
            set
            {
                _meaning = value;
            }
        }

        public string BrightestStar
        {
            get { return _brightestStar; }
            set
            {
                _brightestStar = value;
            }
        }

        public string Hemisphere
        {
            get { return _hemisphere; }
            set
            {
                _hemisphere = value;
            }
        }

        public string Season
        {
            get { return _season; }
            set
            {
                _season = value;
            }
        }

        public string BestSeen
        {
            get { return _bestSeen; }
            set
            {
                _bestSeen = value;
            }
        }

        public string NearbyConstellations
        {
            get { return _nearbyConstellations; }
            set
            {
                _nearbyConstellations = value;
            }
        }

        public string Mythology
        {
            get { return _mythology; }
            set
            {
                _mythology = value;
            }
        }

        public string ImagePathSky
        {
            get { return _imagePathSky; }
            set
            {
                _imagePathSky = value;
            }
        }

        public string ImagePathStars
        {
            get { return _imagePathStars; }
            set
            {
                _imagePathStars = value;
            }
        }

        public string ImagePathPicture
        {
            get { return _imagePathPicture; }
            set
            {
                _imagePathPicture = value;
            }
        }

        //constructor
        public Constellation(string constellationInfo)
        {
            //set the state
            SetState(constellationInfo);
        }

        public void SetState(string constellationInfo)
        {
            string[] data = constellationInfo.Split(',');
            Name = data[0];
            Abbreviation = data[1];
            Genitive = data[2];
            Family = data[3];
            Origin = data[4];
            Meaning = data[5];
            BrightestStar = data[6];
            Hemisphere = data[7];
            Season = data[8];
            BestSeen = data[9];
            NearbyConstellations = data[10];
            Mythology = data[11];
            ImagePathSky = data[12];
            ImagePathStars = data[13];
            ImagePathPicture = data[14];
        }
    }
}
