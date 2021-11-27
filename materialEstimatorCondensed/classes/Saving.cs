using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace materialEstimatorCondensed
{
    public class Saving
    {
        public string Name { get; set; } = "Estimate";
        public string Head { get; set; } = "Material Estimator Program";
        public string Date { get; set; } = DateTime.Now.ToString("f");
        public string Finish { get; set; } = "ESTIMATE COMPLETE";

        public string setSaveLocation(string fileName)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string[] DirSplit = exeDir.Split("\\");

            DirSplit = DirSplit.Where(x => x != "bin" && x != "Debug" && x != "netcoreapp3.1").ToArray();

            string exeDirMod = string.Join("\\", DirSplit);

            string finalPath = $@"{exeDirMod}\files\{fileName}.txt";

            return finalPath;
        }

        public string createHeader()
        {
            string Header = $"{Name,-50}{Head,-60}{Date,35}";

            return Header;
        }

        public string createFooter()
        { 
            string Footer = $"{Finish,85}";

            return Footer;
        }

        public void createItemsReceipt()
        {
            string totalCost = EstimateList.TotalCost.Sum().ToString("C");

            string fileName = finalEstimate.final.saveNameText.Text;

            string filePath = primary.saved.setSaveLocation(fileName);

            if (fileName != "")
            { 
            
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string Header;
                    string Footer;
                    string estimateTotalString = "Estimate Total:";

                    writer.Write($"{Header = createHeader()}" + Environment.NewLine + Environment.NewLine);


                    writer.Write($"{"Category",-10}  |  {"Item",-20}  |  {"Description",-25}  |  {"Size",-30}  |  {"Cost",-10:C}  |  {"Quantity",-10}  |  {"Item Total",-10}" + Environment.NewLine + Environment.NewLine);

                    EstimateList.CreatedEstimates.ForEach(x => writer.Write($"{x.Category,-10}  |  {x.Item,-20}  |  {x.Description,-25}  |  {x.Size,-30}  |  {x.Cost,-10:C}  |  {x.Quantity,-10}  |  {x.Cost * x.Quantity,-10:C}" + Environment.NewLine + Environment.NewLine));

                    writer.Write($"{estimateTotalString,117} {totalCost}" + Environment.NewLine + Environment.NewLine);

                    writer.Write($"{Footer = createFooter()} ");
                }

                string value = finalEstimate.final.finalCostLbl.Text;

                finalEstimate.final.finalCostLbl.Text = $"File Saved at {filePath}";

                Task.Delay(5000).Wait();

                finalEstimate.final.finalCostLbl.Text = value;

            }
            else
            {
                string value = finalEstimate.final.finalCostLbl.Text;

                finalEstimate.final.finalCostLbl.Text = "You Must Name The File";

                Task.Delay(2000).Wait();

                finalEstimate.final.finalCostLbl.Text = value;
            }
        }
    }
}
