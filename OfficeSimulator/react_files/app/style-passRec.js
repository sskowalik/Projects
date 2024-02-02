import { StyleSheet } from 'react-native';
export const styles_passRec = StyleSheet.create({
  container: {
    flexDirection: 'column',
    backgroundColor: '#FFFFFF',
  },
  containerPassRecWindow: {
    height:605,
    backgroundColor: '#FFFFFF',
  },
  recHeader: {
    marginLeft: '16%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 36,
    color: '#656575',
  },
  recText: {
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
  recMailText:{
    marginLeft: '15%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 20,
    lineHeight: 34,
    color: '#B3B3B3',

  },
  recMail:{
    marginLeft: '8%',
    borderWidth: 3,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 44,
    width: 310,
    paddingLeft: 15,
  },
  SubmitButton: {
    marginLeft: '31%',
    marginTop: '8%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 56,
    width: 148,
    backgroundColor: '#F2F2F2',
  },  

  SubmitButtonPressed: {
    marginLeft: '31%',
    marginTop: '8%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#CB3D44',
    borderRadius: 40,
    height: 56,
    width: 148,
    backgroundColor: '#CB3D49',
  },  
  
  SubmitText: {
    fontStyle: 'normal',
    marginTop: '8%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#B3B3B3',
  }, 

  SubmitTextPressed: {
    fontStyle: 'normal',
    marginTop: '8%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#F2F2F2',
  }, 
});