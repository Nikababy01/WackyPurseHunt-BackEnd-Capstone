import axios from 'axios';
import { baseUrl } from './constants.json';

const getAllCustomers = () => new Promise((resolve, reject) => {
  axios.get(`${baseUrl}/customers`)
    .then((response) => resolve(response.data))
    .catch((error) => reject(error));
});

export default { getAllCustomers };
