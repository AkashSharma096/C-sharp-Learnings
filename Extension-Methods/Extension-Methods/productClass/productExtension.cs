using Products;

namespace ProductExtension
{
    public static class ExtendedProduct
    {
        public static double getDiscount(this Product product)
        {
            return product.productCost * product.discountPercentage / 100;
        }
    }
}