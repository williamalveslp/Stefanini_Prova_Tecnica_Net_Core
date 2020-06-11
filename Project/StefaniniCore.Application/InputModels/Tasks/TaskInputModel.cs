namespace StefaniniCore.Application.InputModels.Tasks
{
    public class TaskInputModel
    {
        public int Id { get; set; }


       // [JsonProperty(Order = 1)]
        public string Name { get; set; }


        //[JsonProperty(Order = 2)]
        public string Description { get; set; }
    }
}
