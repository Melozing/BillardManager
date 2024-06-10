using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BillardManager.Model
{
    public partial class FormShowProducts : Form
    {
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            foreach (DataRow item in dataTable.Rows)
            {
                Byte[] imageArray = (byte[])item["item_image"];
                byte[] imageByteArray = imageArray;
                int price = int.Parse(item["item_Price"].ToString());

                Image originalImage = Image.FromStream(new MemoryStream(imageByteArray));
                Image resizedImage = ResizeImage(originalImage, 200, 200); // Resize to 200x200 pixels
                Image compressedImage = CompressImage(resizedImage, 20L); // Compress with 20L quality

                AddItems(item["IdItem"].ToString(), item["item_Name"].ToString(),
                    item["ItemCategory_Name"].ToString(), "$ " + price.ToString("N0"), compressedImage);
            }
        }

        private void AddItems(string idItem, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = idItem
            };
            flowLayoutPanelProduct.Controls.Add(w);
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            string query = "SELECT * " +
                           "FROM items_menu im " +
                           "JOIN items_category ic ON im.IdItemCategory = ic.IdItemCategory " +
                           "WHERE im.ItemStatus != 1 AND im.IdItem != 'IHour'";

            SqlCommand cmd = new SqlCommand(query, MainClass.conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            LoadProducts();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private Image CompressImage(Image image, long quality)
        {
            var jpegEncoder = GetEncoder(ImageFormat.Jpeg);
            var encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

            using (var ms = new MemoryStream())
            {
                image.Save(ms, jpegEncoder, encoderParameters);
                return Image.FromStream(ms);
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
