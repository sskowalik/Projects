import { StyleSheet } from 'react-native';
export const styles_register = StyleSheet.create({
  container: {
    flexDirection: 'column',
    backgroundColor: '#FFFFFF',
  },
  containerPassRegWindow: {
    height:1825,
    backgroundColor: '#FFFFFF',
    
  },
  regHeader: {
    marginLeft: '8%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 30,
    color: '#656575',
    width: 400,
  },
  regText: {
    marginLeft: '8%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#656565',
    textAlign: 'justify',
    width: 325,
    
  },
  regFormText:{
    marginLeft: '15%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 20,
    lineHeight: 34,
    color: '#B3B3B3',

  },
  regForm:{
    marginLeft: '8%',
    borderWidth: 3,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 44,
    width: 310,
    paddingLeft: 15,
  },
  dateText: {
  fontSize: 16,
  color: '#000', // Możesz dostosować kolor do swoich preferencji
  marginTop: '2%',
  padding: 2,
},
  SubmitButton: {
    marginLeft: '25%',
    marginTop: '8%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 56,
    width: 200,
    backgroundColor: '#F2F2F2',
  },  

  SubmitButtonPressed: {
    marginLeft: '25%',
    marginTop: '8%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#CB3D44',
    borderRadius: 40,
    height: 56,
    width: 200,
    backgroundColor: '#CB3D49',
  },  
  
  SubmitText: {
    fontStyle: 'normal',
    marginTop: '7%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#B3B3B3',
  }, 

  SubmitTextPressed: {
    fontStyle: 'normal',
    marginTop: '7%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#F2F2F2',
  }, 
});