namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponseModel : Response
    {
        public int NumOfTrucks { get; set; }
        public OutboundOrderResponseModel() {}

        public OutboundOrderResponseModel(int numOfTrucks)
        {
            NumOfTrucks = numOfTrucks;
            Success = true;
        }

    }
}