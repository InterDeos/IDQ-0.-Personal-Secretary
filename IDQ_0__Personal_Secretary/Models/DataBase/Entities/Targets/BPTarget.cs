namespace IDQ_0__Personal_Secretary.Models.DataBase.Entities.Targets
{
    public class BPTarget:Target
    {
        public int BuisnessProcessId { get; set; }
        public BuisnessProcess BP  { get; set; }

        public BPTarget Initialize()
        {
            Id = Id != 0 ? Id : Id;
            IsAchieved = IsAchieved ? IsAchieved : IsAchieved;
            Name = Name ?? "Name Target";

            return this;
        }
    }
}
