using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace materialEstimatorCondensed
{
    public class Material
    {
        public string Category { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public double Cost { get; set; }

        // Read json from file
        public void readJson()
        {
            string jsonPath = getFileLocation(@"materialList.json");
            using (StreamReader r = new StreamReader(@$"{jsonPath}"))
            {
                string json = r.ReadToEnd();
                JObject material = JObject.Parse(json);

                for (int i = 1; i <= 29; i++)
                {
                    string materials = material[$"{i}"].ToString();
                    Material materialItems = JsonConvert.DeserializeObject<Material>(materials);
                    EstimateList.CreatedMaterials.Add(materialItems);
                }
            }
        }

        // Get location of image for form
        public string getImageLocation(string jsonFile)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string[] DirSplit = exeDir.Split("\\");
            DirSplit = DirSplit.Where(x => x != "bin" && x != "Debug" && x != "netcoreapp3.1").ToArray();
            string exeDirMod = string.Join("\\", DirSplit);
            string jsonPath = $@"{exeDirMod}\images\{jsonFile}";

            return jsonPath;
        }

        // Get file location to select files for program
        public string getFileLocation(string jsonFile)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string[] DirSplit = exeDir.Split("\\");
            DirSplit = DirSplit.Where(x => x != "bin" && x != "Debug" && x !="netcoreapp3.1").ToArray();
            string exeDirMod = string.Join("\\", DirSplit);
            string jsonPath = $@"{exeDirMod}\data\{jsonFile}";

            return jsonPath;
        }

        // Creates material
        public Material generateMaterial(string category, string item, string description, string size, double cost)
        {
            Material create = new Material();

            create.Category = category;
            create.Item = item;
            create.Description = description;
            create.Size = size;
            create.Cost = Convert.ToDouble(cost);

            return create;
        }

        // textbox validation and inputs
        public void addTextBoxValues(secondary form)
        {
            int checkQuantity;
            double checkPrice;
            bool isQuantity = int.TryParse(form.quantityText.Text, out checkQuantity);
            bool isPrice = double.TryParse(form.priceText.Text.Replace("$", ""), out checkPrice);

            if (form.itemText.Text == "Category" && form.itemText.Text == "Item" && form.descriptionText.Text == "Description" && form.sizeText.Text == "Size" && form.priceText.Text == "Cost" || form.quantityText.Text == "" && form.quantityText.Text != "")
            {
                form.itemText.Text = form.descriptionText.Text = form.sizeText.Text = form.priceText.Text = form.quantityText.Text = "";
                form.userUpdateLbl.Text = "That line can not be added to your final estimate";
            }
            else if (form.categoryText.Text == "")
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Category box";
            }
            else if (form.itemText.Text == "")
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Item box";
            }
            else if (form.descriptionText.Text == "")
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Decscription box";
            }
            else if (form.sizeText.Text == "")
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Size box";
            }
            else if (form.priceText.Text == "" || isPrice == false)
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Price box";
            }
            else if (form.quantityText.Text == "" || isQuantity == false)
            {
                form.userUpdateLbl.Text = "You must give a valid input to the Quantity box";
            }
            else
            {
                try
                {
                    string category = form.categoryText.Text.Trim();
                    string item = form.itemText.Text.Trim();
                    string description = form.descriptionText.Text.Trim();
                    string size = form.sizeText.Text;
                    string floorPrice = form.priceText.Text.Replace("$", "").Trim();
                    double cost = double.Parse(floorPrice);
                    int quantity = int.Parse(form.quantityText.Text.Trim());

                    primary.estimate.generateEstimate(category, item, description, size, cost, quantity);

                    form.quantityText.Text = "";
                    primary.material.clearTextBoxes(form);

                    form.userUpdateLbl.Text = "Material Added Successfully!";
                    Task.Delay(2000).Wait();
                    form.userUpdateLbl.Text = "";

                    double totalCostValue = cost * quantity;
                    EstimateList.TotalCost.Add(totalCostValue);
                }
                catch
                {
                    form.userUpdateLbl.Text = "Material Could Not Be Added!";
                    Task.Delay(2000).Wait();
                    form.userUpdateLbl.Text = "";
                }

            }

        }

        // clear textboxes
        public void clearTextBoxes(secondary form)
        {
            form.categoryText.Text = form.itemText.Text = form.descriptionText.Text = form.sizeText.Text = form.priceText.Text = form.quantityText.Text = "";
        }

        // clear list box
        public void clearListBox(secondary form)
        {
            form.secondaryListBox.Items.Clear();
        }

        // set text box values to selected text
        public void setTextBoxValues(secondary form, List<string> finalSelected)
        {
            var list = finalSelected;
            form.categoryText.Text = finalSelected[0].Replace("|", "").Trim();
            form.itemText.Text = finalSelected[1].Replace("|", "").Trim();
            form.descriptionText.Text = finalSelected[2].Replace("|", "").Trim();
            form.sizeText.Text = finalSelected[3].Replace("|", "").Trim();
            form.priceText.Text = finalSelected[4].Replace("|", "").Trim();
        }

        // set listbox values to floor
        public void setFloor()
        {
            secondary.floor.headerLbl.Text = "Floor Material";

            List<Material> supplies = EstimateList.CreatedMaterials.Where(x => x.Category == "Floor").ToList();

            secondary.floor.secondaryListBox.Items.Add($"{"Category",-15}{"Item",-25}| {"Description",-28}| {"Size",-30}| {"Cost",-10:C}");

            supplies.ForEach(x => secondary.floor.secondaryListBox.Items.Add(String.Format($"{x.Category,-15}{x.Item,-25}| {x.Description,-28}| {x.Size,-30}| {x.Cost,10:C}")));
        }

        // set listbox values to wall
        public void setWall()
        {
            secondary.wall.headerLbl.Text = "Wall Material";

            List<Material> supplies = EstimateList.CreatedMaterials.Where(x => x.Category == "Wall").ToList();

            secondary.floor.secondaryListBox.Items.Add($"{"Category",-15}{"Item",-25}| {"Description",-28}| {"Size",-30}| {"Cost",-10:C}");

            supplies.ForEach(x => secondary.floor.secondaryListBox.Items.Add(String.Format($"{x.Category,-15}{x.Item,-25}| {x.Description,-28}| {x.Size,-30}| {x.Cost,10:C}")));
        }

        // set listbox values to openings
        public void setOpenings()
        {
            secondary.openings.headerLbl.Text = "Openings Material";

            List<Material> supplies = EstimateList.CreatedMaterials.Where(x => x.Category == "Openings").ToList();

            secondary.floor.secondaryListBox.Items.Add($"{"Category",-15}{"Item",-25}| {"Description",-28}| {"Size",-30}| {"Cost",-10:C}");

            supplies.ForEach(x => secondary.floor.secondaryListBox.Items.Add(String.Format($"{x.Category,-15}{x.Item,-25}| {x.Description,-28}| {x.Size,-30}| {x.Cost,10:C}")));
        }

        // set listbox values to roof
        public void setRoof()
        {
            secondary.roof.headerLbl.Text = "Roof Material";

            List<Material> supplies = EstimateList.CreatedMaterials.Where(x => x.Category == "Roof").ToList();

            secondary.floor.secondaryListBox.Items.Add($"{"Category",-15}{"Item",-25}| {"Description",-28}| {"Size",-30}| {"Cost",-10:C}");

            supplies.ForEach(x => secondary.floor.secondaryListBox.Items.Add(String.Format($"{x.Category,-15}{x.Item,-25}| {x.Description,-28}| {x.Size,-30}| {x.Cost,10:C}")));
        }

        // select appropriate form based on user material selection
        public secondary getCorrectForm()
        {
            switch (EstimateList.ActiveForm)
            {
                case 1:
                    secondary form = secondary.floor;
                    return form;
                case 2:
                    form = secondary.wall;
                    return form;
                case 3:
                    form = secondary.openings;
                    return form;
                case 4:
                    form = secondary.roof;
                    return form;
                default:
                    form = secondary.floor;
                    return form;
            }
        }
    }
}
