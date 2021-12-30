using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{

    //staticler newlenmiyor. paso sabit yapı oluyor
    public static class Messages
    {

        public static string ProductAdded = "Product Added! ";
        public static string ProductNameInvalid = "Invalid Product Name!";
        public static string MaintenanceTime = "System Under Maintenance!";
        public static string ProductListed = "Products are Listed!";
        public static string ProductCountOfCategoryError = "One Category must have lower than 10 products!";
        public static string ProductNameAlreadyExists = "Product Name Already Exists!";
        public static string CategoryLimitExceded = "Category Limit Has Exceded! Unable to add new product!";
    }
}
