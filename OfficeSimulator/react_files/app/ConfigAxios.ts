import axios from 'axios'

export default axios.create({
    baseURL:"http://10.204.35.180:8080", //IP za kazdym razem sie zmienia!!!! // 192.168.137.183 -seba
    headers:{
        "Content-Type":"application/json"
    }
})