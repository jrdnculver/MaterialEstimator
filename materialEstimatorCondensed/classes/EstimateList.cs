using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materialEstimatorCondensed
{
    public class EstimateList
    {
        // Created Material List
        public static List<Material> CreatedMaterials = new List<Material>();

        // Created Estimates List
        public static List<MaterialSelection> CreatedEstimates = new List<MaterialSelection>();

        // Total Cost List
        public static List<double> TotalCost = new List<double>();
        public static int ActiveForm { get; set; }

        // Creates the output for final Estimate
        public void settingFinalEstimate()
        {
            finalEstimate.final.finalListBox.Items.Add($"{"Catergory", -10}  |  {"Item",-20}  |  {"Description",-25}  |  {"Size",-28}  |  {"Cost",-10:C}  |  {"Quantity",-10}  |  {"Item Cost",-10}");

            CreatedEstimates.ForEach(x => finalEstimate.final.finalListBox.Items.Add($"{x.Category,-10}  |  {x.Item,-20}  |  {x.Description,-25}  |  {x.Size,-28}  |  {x.Cost,10:C}  |  {x.Quantity,10}  |  {x.Cost * x.Quantity,10:C}"));

            finalEstimate.final.finalCostLbl.Text = TotalCost.Sum().ToString("C");
        }

        // Removes all content from list box
        public void clearAllFinalListBox()
        {
            finalEstimate.final.finalListBox.Items.Clear();

            finalEstimate.final.finalListBox.Items.Add($"{"Catergory",-10}  |  {"Item",-20}  |  {"Description",-25}  |  {"Size",-28}  |  {"Cost",-10:C}  |  {"Quantity",-10}");

            TotalCost.RemoveRange(0, TotalCost.Count);

            CreatedEstimates.RemoveRange(0, CreatedEstimates.Count);

            finalEstimate.final.finalCostLbl.Text = "Return Home To Add More Items";
        }

        // Clears single item from list box
        public void clearSingleFinalListBox()
        {
            try
            {
                double value = double.Parse(finalEstimate.final.finalCostLbl.Text.Replace("$", "").Trim());

                string itemSelected;

                if (finalEstimate.final.finalListBox.SelectedItem != null)
                {
                    itemSelected = finalEstimate.final.finalListBox.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception();
                }

                
                finalEstimate.final.finalCostLbl.Text = "Return Home To Add More Items";
                
            
                finalEstimate.final.finalListBox.Items.Remove(itemSelected);


                List<string> selected = itemSelected.Split("  ").ToList();
                List<string> finalSelected = selected.Where(x => x != "" && x != "|" && x != " |").ToList();

                string item = finalSelected[1].Replace("|", "").Trim();
                string description = finalSelected[2].Replace("|", "").Trim();
                string size = finalSelected[3].Replace("|", "").Trim();
                double cost = double.Parse(finalSelected[4].Replace("|", "").Replace("$", "").Trim());
                int quantity = int.Parse(finalSelected[5].Replace("|", "").Trim());

                double itemCost = cost * quantity;

                TotalCost.Remove(itemCost);

                CreatedEstimates.RemoveAll(x => x.Item.ToString() == item.ToString() && x.Description.ToString() == description.ToString() && x.Size == size.ToString() && x.Cost.ToString() == cost.ToString());


                finalEstimate.final.finalCostLbl.Text = $"{value - itemCost:C}";
            }
            catch 
            {
                string value = finalEstimate.final.finalCostLbl.Text;

                finalEstimate.final.finalCostLbl.Text = "You Must Select An Item To Remove It";

                Task.Delay(2000).Wait();

                finalEstimate.final.finalCostLbl.Text = value;
              
            }
        }
    }
}
