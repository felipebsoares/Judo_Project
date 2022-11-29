import axios from 'axios';

const api = axios.create({
  baseURL: 'https://judoapi.azurewebsites.net',
});

export { api };
