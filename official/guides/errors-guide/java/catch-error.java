package errors;

import java.util.HashMap;

import com.easypost.EasyPost;
import com.easypost.exception.EasyPostException;

public class CatchError {
    public static void main(String[] args) throws EasyPostException {
        EasyPost.apiKey = System.getenv("EASYPOST_API_KEY");

        try {
            Map<String, Object> address = new HashMap<String, Object>();

            address.put("verify_strict", true);

            Address.create(address);
        } catch (EasyPostException e) {
            System.err.println(e.getMessage());
        }
    }
}
