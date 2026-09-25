using System;
using System.Collections.Generic;
using System.Text;

namespace _0zadanie
{
    internal class SortArray
    {
        public float[] Array { get; set; }
        public float[] BubleSort { get; set; }
        public float[] InsertArray { get; set; }
        public float[] SelectArray { get; set; }


        public SortArray(float[] aLotOfNumbersArray, float[] bubleSort, float[] insertion, float[] selection)
        {
            this.Array = aLotOfNumbersArray;
            this.BubleSort = bubleSort;
            this.InsertArray = insertion;
            this.SelectArray = selection;
        }
        static public float[] SetBubleSort(float[] aLotOfNumbersArray)
        {

            float[] bubleSort = CopyArray(aLotOfNumbersArray);
            for (int j = 0; j < bubleSort.Length; j++)
            {
                for (int i = 0; i < bubleSort.Length; i++)
                {
                    if (bubleSort[j] > bubleSort[i])
                    {
                        float save = bubleSort[j];
                        bubleSort[j] = bubleSort[i];
                        bubleSort[i] = save;


                    }

                }
            }

            return bubleSort;
        }
        static public float[] SetInsertionSort(float[] aLotOfNumbersArray)
        {
            float[] insertArray = CopyArray(aLotOfNumbersArray);

            for (int j = 1; j < insertArray.Length; j++)
            {
                for (int i = j - 1; i >= 0; i--)
                {
                    if (insertArray[j] < insertArray[i])
                    {
                        float save = insertArray[i];
                        insertArray[i] = insertArray[j];
                        insertArray[i + 1] = save;

                    }


                }
            }
            return insertArray;

        }

         static public float[] SetSelectionSort(float[] aLotOfNumbersArray)
        {
            float[] selectArray = CopyArray(aLotOfNumbersArray);
            for (int i = 1; i < selectArray.Length; i++)
            {
                int j = i;

                while (j > 0 && selectArray[j] < selectArray[j - 1])
                {
                    float save = selectArray[j];

                    selectArray[j] = selectArray[j - 1];
                    selectArray[j - 1] = save;

                    j--;

                }
            }


            return selectArray;
        }
        static float[] CopyArray(float[] aLotOfNumbersArray)
        {
            float[] arrayCopy = new float[aLotOfNumbersArray.Length];
            for (int i = 0; i < aLotOfNumbersArray.Length; i++)
            {
                arrayCopy[i] = aLotOfNumbersArray[i];
            }
            return arrayCopy;
        }

    }

}
