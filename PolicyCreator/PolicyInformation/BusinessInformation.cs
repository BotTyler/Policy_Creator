using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;

namespace InsuranceSummaryMaker.PolicyInformation
{



    internal class BusinessInformation
    {
        public string _name { get; }
        public string _legalName { get; }
        public DateTime _start { get; set; }
        public DateTime _end { get; set; }

        public businessImage _image { get; set; }


        public BusinessInformation(string name, string legalName, DateTime start, DateTime end, businessImage img)
        {
            this._name = name;
            this._legalName = legalName;
            this._start = start;
            this._end = end;
            this._image = img;


        }

        public BusinessInformation(JToken json)
        {
            this._name = json["_name"] + "";
            this._legalName = json["_legalName"] + "";
            this._start = DateTime.Parse(json["_start"] + "");
            this._end = DateTime.Parse(json["_end"] + "");

            string base64Image = json["_image"] + "";
            string imageType = json["_imageTypes"] + "";
            string height = json["_height"] + "";
            string width = json["_width"] + "";

            this._image = new businessImage(base64Image, width, height, imageType);


        }



        public string getFormattedStartDate()
        {
            return _start.ToString("MM/dd/yyyy");
        }

        public string getFormattedEndDate()
        {
            return _end.ToString("MM/dd/yyyy");
        }

        public override string ToString()
        {
            return string.Format("Name:\n{0}\n\nLegal Name:\n{1}\n\nStart Date:\n{2}\n\nExpiration Date:\n{3}", this._name, this._legalName, getFormattedStartDate(), getFormattedEndDate());
        }

        public Dictionary<string, object> Serialize()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("_name", _name);
            dict.Add("_legalName", _legalName);
            dict.Add("_start", _start);
            dict.Add("_end", _end);
            if(this._image != null)
            {
                dict.Add("_image", this._image.getImageBase64());
                dict.Add("_imageTypes", this._image._imageType);
                dict.Add("_width", this._image._width);
                dict.Add("_height", this._image._height);
            }
            else
            {
                dict.Add("_image", "");
                dict.Add("_imageTypes", "");
                dict.Add("_width", "");
                dict.Add("_height", "");
            }


            return dict;
        }
    }




    internal class businessImage
    {



        public ImagePartType _imageType { get; private set; }
        public byte[] _image { get; set; }

        public int _width { get; set; }
        public int _height { get; set; }

        public businessImage(string base64, string width, string height, string type)
        {
            this._image = getBytesFromBase64(base64);
            if (isImageNull())
            {
                return;
            }
            this._width = int.Parse(width);
            this._height = int.Parse(height);
            this._imageType=(ImagePartType)int.Parse(type);


        }
        
        public businessImage(byte[] image, int width, int height, ImagePartType type)
        {
            this._image = image;
            this._width = width;
            this._height = height;
            this._imageType = type;


        }


        public Image getImageFromBytes()
        {
            if (this._image == null)
            {
                return null;
            }


            Image img;
            using (MemoryStream ms = new MemoryStream(_image))
            {
                img = Image.FromStream(ms);
            }
            return img;
        }






        public byte[] getBytesFromBase64(string base64string)
        {
            if (base64string.Equals(""))
            {
                return null;
            }
            return Convert.FromBase64String(base64string);


        }

        public string getImageBase64()
        {
            if (isImageNull()) { return ""; }
            string base64Image = Convert.ToBase64String(this._image);
            return base64Image;

        }










        // fix below

        public bool isImageNull()
        {
            return this._image == null;
        }

        public static ImagePartType getPathImageType(string path)
        {
            switch (Path.GetExtension(path))
            {
                case ".jpg":
                    return ImagePartType.Jpeg;
                    break;
                case ".jpeg":
                    return ImagePartType.Jpeg;
                    break;
                case ".png":
                    return ImagePartType.Png;
                    break;
                default:
                    return ImagePartType.Jpeg;
                    break;
            }
        }


    }
}
