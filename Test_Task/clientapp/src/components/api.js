import axios from "axios";

const baseUrl = "https://localhost:44398/api/";



export default {

    Users(url = baseUrl + 'users/') {
        return {
            getUsers: () => axios.get(url),
            fetchById: id => axios.get(url + id),
            createSQL: sqlrequest => axios.post(url, sqlrequest),
            update: (id, updateRecord) => axios.put(url + id, updateRecord),
            deleteUser: id => axios.delete(url + id)
        }
    }
}
