using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerCollectingWizard.Scripts
{
    class ProductImage : OnlineProducts
    {
        public Image CategoryControl(OnlineProducts.PC_Category category, double price)
        {
            switch (category)
            {
                case OnlineProducts.PC_Category.AllinOne:
                    return AllinOne(price);
                case OnlineProducts.PC_Category.Dekstop:
                    return Desktop(price);
                case OnlineProducts.PC_Category.geForce:
                    return Desktop(price);
                case OnlineProducts.PC_Category.Laptop:
                    return Laptop(price);
                default: return null;
            }
        }

        public Image AllinOne(double Price)
        {
            string grade;

            if (Price < 4500.00)
                grade = "low";
            else if (Price < 7000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowAIO;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumAIO;
                    }
                case "high":
                    {
                        return Properties.Resources.highAIO;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
        public Image Desktop(double Price)
        {
            string grade = null;

            if (Price < 3000.00)
                grade = "low";
            else if (Price < 6000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowDP;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumDP;
                    }
                case "high":
                    {
                        return Properties.Resources.highDP;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
        public Image Laptop(double Price)
        {
            string grade;

            if (Price < 7000.00)
                grade = "low";
            else if (Price < 15000.00)
                grade = "medium";
            else
                grade = "high";

            switch (grade)
            {
                case "low":
                    {
                        return Properties.Resources.lowLAPTOP;
                    }
                case "medium":
                    {
                        return Properties.Resources.mediumLAPTOP;
                    }
                case "high":
                    {
                        return Properties.Resources.highLAPTOP;
                    }
                default:
                    return Properties.Resources.unKnownPcImage;
            }
        }
    }
}
