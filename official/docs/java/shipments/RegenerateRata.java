import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class RegenerateRata {
    public static void main(String [] args){
        EasyPost.apiKey = "<EASYPOST_API_KEY>";

        Shipment shipment = Shipment.retrieve("shp_...");

        shipment = shipment.newRates();

        System.out.println(shipment);
    }
}
