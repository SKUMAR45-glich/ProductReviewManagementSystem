using System;
using System.Collections.Generic;

namespace ProductReviewManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Product Review Management System!");



            //UC1 Creating the list of data of Products

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 2, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 3, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 4, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 6, Rating = 1, Review = "bas", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 7, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 8, UserID = 8, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 9, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 10, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 10, Rating = 7, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 12, UserID = 12, Rating = 6, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 13, Rating = 5, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 14, UserID = 14, Rating = 4, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 15, UserID = 15, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 16, UserID = 16, Rating = 2, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 17, UserID = 17, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 18, UserID = 18, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 19, UserID = 19, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 20, UserID = 20, Rating = 7, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 21, UserID = 21, Rating = 6, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 22, UserID = 22, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 23, UserID = 23, Rating = 9, Review = "nice", isLike = false },
                new ProductReview() { ProductID = 24, UserID = 24, Rating = 15, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 25, UserID = 25, Rating = 20, Review = "nice", isLike = true }
            };



            // Display the List of Table
            
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID " + list.UserID
                    +  " Rating:- " + list.Rating + " Review:-" + list.Review + " isLike: - " + list.isLike);

            }

            Console.WriteLine("\n");
            


            Management management = new Management();                       //Instializing Object of class Management


            //management.TopRecords(productReviewList);                     //UC2 Retrieve Top 3 Records from the list

            //management.SelectedRecords(productReviewList);                //UC3 Retrive Selected Records of the list

            //management.RetrieveCountofRecords(productReviewList);         //UC4 Count the Records of the list

            //management.RetrieveProductIDandReview(productReviewList);       //UC5 Get the Product ID and Records in the list

            //management.SkipTop5Records(productReviewList);                // UC6 Skip the Top 5 Records of the list

            management.RetrieveDataWithisLikevalueTrue(productReviewList);     //UC7 Retrieve Records with True values from the list

        }
    }
}
