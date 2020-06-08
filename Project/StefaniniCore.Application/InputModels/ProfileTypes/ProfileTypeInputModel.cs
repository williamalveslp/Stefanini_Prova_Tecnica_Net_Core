namespace StefaniniCore.Application.InputModels.ProfileTypes
{
    public class ProfileTypeInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int[] TaskIds { get; set; }
    }
}
