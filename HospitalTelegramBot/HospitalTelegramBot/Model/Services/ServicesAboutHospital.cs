using System.Xml;

namespace HospitalTelegramBot.Model.Services
{
    class AboutHospital
    {
        public static string InfoAboutHotel
        {
            get
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"..\..\Model\AboutHospital.xml");

                return xDoc.SelectSingleNode("//data/infoAboutHospital").InnerText;
            }
        }

        public static string ImageAboutHotel
        {
            get
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"..\..\Model\AboutHospital.xml");

                return xDoc.SelectSingleNode("//data/imageAboutHospital").InnerText;
            }
        }
    }
}
