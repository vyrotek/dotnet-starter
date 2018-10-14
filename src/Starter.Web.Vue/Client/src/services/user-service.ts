import axios from 'axios';

export default class UserService {
    public async getUsers() {        
        return (await axios.get('/api/users')).data;
    }
}