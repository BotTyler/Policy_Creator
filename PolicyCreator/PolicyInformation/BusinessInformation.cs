using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace InsuranceSummaryMaker.PolicyInformation
{
    public enum imageTypes
    {
        JPEG, PNG
    }
    internal class BusinessInformation
    {
        public string _name { get; }
        public string _legalName { get; }
        public DateTime _start { get; set; }
        public DateTime _end { get; set; }

        public byte[] _image { get; set; }
        public imageTypes _imageTypes { get; set; }
        public float _imageAspectRatio { get; set; }


        public BusinessInformation(string name, string legalName, DateTime start, DateTime end, Image img, string imagePath)
        {
            this._name = name;
            this._legalName = legalName;
            this._start = start;
            this._end = end;
            this._image = getImageBytes(img);
            this._imageAspectRatio = img.Width / (float)img.Height;

            switch (Path.GetExtension(imagePath))
            {
                case ".jpg":
                    this._imageTypes = imageTypes.JPEG;
                    break;
                case ".jpeg":
                    this._imageTypes = imageTypes.JPEG;
                    break;
                case ".png":
                    this._imageTypes = imageTypes.PNG;
                    break;
                default:
                    this._imageTypes = imageTypes.JPEG;
                    break;
            }
        }

        public BusinessInformation(JToken json)
        {
            this._name = json["_name"] + "";
            this._legalName = json["_legalName"] + "";
            this._start = DateTime.Parse(json["_start"] + "");
            this._end = DateTime.Parse(json["_end"] + "");
            this._image = getImageBytes(json["_image"] + "");
            this._imageAspectRatio = float.Parse(json["_imageAspectRatio"] + "");

            switch (json["_imageTypes"] + "")
            {
                case "JPEG":
                    this._imageTypes = imageTypes.JPEG;
                    break;
                case "PNG":
                   this._imageTypes = imageTypes.PNG;
                    break;
                default:
                    this._imageTypes = imageTypes.JPEG;
                    break;
            }
        }

        public Image getImageFromBytes()
        {
            Image img;
            using(MemoryStream ms = new MemoryStream(this._image))
            {
                img = Image.FromStream(ms);
            }
            return img;
        }



        public string getImageBase64(byte[] imageBytes)
        {
            string base64Image = Convert.ToBase64String(imageBytes);
            return base64Image;

        }

        private byte[] getImageBytes(Image image)
        {
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); // Save the image to the stream
                imageBytes = ms.ToArray(); // Convert the stream to byte[]
            }

            return imageBytes;
        }

        private byte[] getImageBytes(string base64string)
        {
            byte[] imageBytes = Convert.FromBase64String(base64string);
            

            return imageBytes;
        }

        public string getFormattedStartDate()
        {
            return _start.ToLongDateString();
        }

        public string getFormattedEndDate()
        {
            return _end.ToLongDateString();
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
            dict.Add("_image", getImageBase64(this._image));
            dict.Add("_imageTypes", _imageTypes);
            dict.Add("_imageAspectRatio", _imageAspectRatio);
            return dict;
        }
    }
}
