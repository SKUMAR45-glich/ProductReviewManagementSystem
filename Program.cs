using System;
using System.Collections.Generic;

namespace ProductReviewManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<ProductReview> productReviewList = new List<ProductReview>()

            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 2, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 3, UserID = 1, Rating = 5, Review = "Good", isLike = true },
                new ProductReview() { ProductID = 4, UserID = 1, Rating = 6, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 2, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 6, UserID = 1, Rating = 1, Review = "bas", isLike = true },
                new ProductReview() { ProductID = 7, UserID = 1, Rating = 1, Review = "Good", isLike = false },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 9, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 9, UserID = 1, Rating = 10, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 10, UserID = 1, Rating = 8, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 11, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 12, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 13, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 14, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 16, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 17, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 18, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 19, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 20, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 21, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 22, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 23, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 24, UserID = 1, Rating = 3, Review = "nice", isLike = true },
                new ProductReview() { ProductID = 25, UserID = 1, Rating = 3, Review = "nice", isLike = true }


            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "" + list.UserID
                    + "" + "Rating:-" + list.Rating + "" + "Review:-" + list.Review + "" + "isLike: - " + list.isLike);

            }

        }
    }
}
