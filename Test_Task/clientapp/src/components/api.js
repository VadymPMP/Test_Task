import axios from "axios";
import configData from "./config/config.json";

//const baseUrl = "https://localhost:44398/api/";


//C:\Users\User\Desktop\Test_Task-master\Test_Task\clientapp\config.json
export default {

    Datas(url = configData.SERVER_URL + 'users/') {
        return {
            getData: () => axios.get(url),
            createSQL: sqlrequest => axios.post(url, sqlrequest),
        }
    }
}
