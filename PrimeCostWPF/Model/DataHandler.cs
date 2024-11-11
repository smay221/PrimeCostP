using Newtonsoft.Json;
using PrimeCostWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace PrimeCostWPF.Model
{
    public static class DataHandler
    {
        public static int[] idx;
        public static List<object> dataContext;

        //public static IProductComponent jsonGoDown() //Метод получения внутрянки выбранной Субпозиции
        //{
        //    IProductComponent currentSubPos = ConstantsLibrary.root.productComposition[0];
        //    for (int i = 0; i < idx.Length; i++)
        //    {
        //        currentSubPos = currentSubPos.SubPositions[idx[i]];
        //    }
        //    return currentSubPos;
            
        //}


        public static List<object> chageLevelList(SubPosition selectedMaterial)
        {
            List<object> dataContext = new List<object>();
            if (selectedMaterial.materials != null)
            {
                foreach (Materials material in selectedMaterial.materials)
                {
                    dataContext.Add(material);
                }
            }
           if (selectedMaterial.SubPositions != null)
            {
                foreach (SubPosition subPos in selectedMaterial.SubPositions)
                {
                    dataContext.Add(subPos);
                }
            }
            

            return dataContext;

        }







    }

}


