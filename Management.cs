using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementSystem
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "" + list.UserID
                    + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "isLike: - " + list.isLike);
            }
        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "" + list.UserID
                    + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "isLike: - " + list.isLike);
            }
        }

        public void RetrieveCountofRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + " " + list.Count);
            }
        }



        // to get the Product ID and Reviews

        public void RetrieveProductIDandReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select ( new { productReviews.ProductID, productReviews.Review });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + " " + list.Review);
            }
        }
    }

}