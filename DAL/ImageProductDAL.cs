using System.Collections.Generic;
using System.Data;
using CuaHangDoChoiAPI.Models;
using CuaHangDoChoiAPI.Utils;
using Microsoft.Data.SqlClient;

namespace CuaHangDoChoiAPI.DAL
{
     public class ImageProductDAL
    {
        public int addImageProduct(ImageProduct imageProduct)
        {
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@ProductID", imageProduct.ProductID),
                new SqlParameter("@Image", imageProduct.Image)
            };
            return DBHelper.NonQuery("addImageProduct", parameters);
        }

        public int updateImageProduct(int ID, ImageProduct imageProduct)
        {
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@ID", ID),
                new SqlParameter("@ProductID", imageProduct.ProductID),
                new SqlParameter("@Image", imageProduct.Image)
            };
            return DBHelper.NonQuery("updateImageProduct", parameters);
        }

        public int deleteImageProduct(int ID)
        {
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@ID", ID)
            };
            return DBHelper.NonQuery("deleteImageProduct", parameters);
        }

        public ImageProduct GetImageProduct(int ID)
        {
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@ID", ID)
            };
            DataTable dataTable = DBHelper.Query("getImageProductByID", parameters);
            ImageProduct imageProduct = null;
            foreach (DataRow dr in dataTable.Rows)
            {
                imageProduct = new ImageProduct()
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    Image = dr["Image"].ToString(),
                    IsActive = int.Parse(dr["IsActive"].ToString()),
                    ProductID = int.Parse(dr["ProductID"].ToString())
                };
            }

            return imageProduct;
        }

        public List<ImageProduct> getImageProduct(int IDProduct)
        {
            SqlParameter[] parameters = new[]
            {
                new SqlParameter("@ProductID", IDProduct)
            };
            List<ImageProduct> imageProducts = new List<ImageProduct>();
            DataTable dataTable = DBHelper.Query("getImageProduct", parameters);
            foreach (DataRow dr in dataTable.Rows)
            {
                ImageProduct imageProduct = new ImageProduct()
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    Image = dr["Image"].ToString(),
                    IsActive = int.Parse(dr["IsActive"].ToString()),
                    ProductID = int.Parse(dr["ProductID"].ToString())
                };
                imageProducts.Add(imageProduct);
            }

            return imageProducts;
        }
    }
}