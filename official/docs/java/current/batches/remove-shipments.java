package batches;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;
import com.easypost.model.Batch;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class RemoveShipments {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        Batch batch = Batch.retrieve("batch_...");

        HashMap<String, Object> shipment1 = new HashMap<String, Object>();
        shipment1.put("id", "shp_...");

        List<HashMap<String, Object>> shipments = new ArrayList<HashMap<String, Object>>();
        shipments.add(shipment1);

        HashMap<String, Object> batchMap = new HashMap<String, Object>();
        batchMap.put("shipments", shipments);

        batch.removeShipments(batchMap);

        System.out.println(batch);
    }
}
