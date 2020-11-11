namespace DriveEntities.Entities
{
    public class VehicleDto : EntityBase<long>
    {
        public string ModelName { get; set; }

        public string Number { get; set; }

        public byte[] Photo { get; set; }
    }
}