import { StyleSheet } from 'react-native';
export const styles_offices = StyleSheet.create({
  container: {
    flexDirection: 'column',
    backgroundColor: '#FFFFFF',
  },
  containerPassRegWindow: {
    height:1825,
    backgroundColor: '#FFFFFF',
    
  },
  officesHeader: {
    marginLeft: '8%',
    marginTop: '6%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 30,
    color: '#656575',
    width: 400,
  },
  officesText: {
    marginLeft: '8%',
    marginTop: '6%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#656565',
    textAlign: 'justify',
    width: 325,
    
  },
  officesFormText:{
    marginLeft: '15%',
    marginTop: '6%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 20,
    lineHeight: 34,
    color: '#B3B3B3',

  },
  officesForm:{
    marginLeft: '8%',
    backgroundColor: '#F3F3F3',
    height: 44,
    width: 310,
    paddingLeft: 15,
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