import { StyleSheet } from 'react-native';
export const styles_login = StyleSheet.create({
  container: {
    flexDirection: 'column',
    backgroundColor: '#FFFFFF',
  },    
  containerTopBar: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    backgroundColor: '#F2F2F2',
    height: 70,
  },  
  herbPolski: {
    width: 51,
    height: 60,
    marginLeft: '13%',
    marginTop: '1%',
  },
  urzedasPl: {
    marginLeft: '0%',
    marginTop: '1%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 30,
    lineHeight: 48,
    color: '#000000',
  },
  info: {
    marginLeft: '2%',
    marginTop: '1%',
    width: 50,
    height: 50,
    padding: 0,
  },
  lineTop: {
    borderWidth: 1,
    borderColor: '#B3B3B3',
  },

  logo: {
    marginLeft: '33%',
    marginTop: '3%',
    borderWidth: 2,
    borderColor: '#000000',
    width: 130,
    height: 130,
  },

  logowanie: {
    marginLeft: '25%',
    marginTop: '2%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 34,
    lineHeight: 34,
    color: '#B3B3B3',
  },

  containerLoginWindow: {
    marginLeft: '4%',
    flexDirection: 'flex',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 174,
    width: 360,
  },  
  
  loginText: {
    marginLeft: '10%',
    marginTop: '1%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#B3B3B3',
  },  

  loginField: {
    marginLeft: '6%',
    borderWidth: 3,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 44,
    width: 310,
    paddingLeft: 15,
  },  

  forgotPassword: {
    marginLeft: '42%',
    marginTop: '1%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#656565',
  },  

  noAccount: {
    marginLeft: '14%',
    marginTop: '1%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#B3B3B3',
    width: 174,
  },  

  register: {
    marginLeft: '14%',
    marginTop: '1%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#656565',
    width: 117,
  },  

  containerBody: {
    height: 246,
    width: 400,
  },

  containerBottomBar: {
    flexDirection: 'row',
    alignItems: 'center',
    backgroundColor: '#CB3D49',
    height: 65,
  },  

  coi: {
    width: 76.75,
    height: 30,
    marginLeft: '4%',
  },
  
  mc: {
    width: 97,
    height: 43.2,
    marginLeft: '4%',
  },

  versionText: {
    fontStyle: 'normal',
    fontWeight: '400',
    fontSize: 18,
    lineHeight: 20,
    color: '#D6D6D6',
    marginLeft: '25%',
    marginTop: '6%',
  },

  containerLoginConfirm: {
    marginLeft: '31%',
    marginTop: '5%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    borderRadius: 40,
    height: 56,
    width: 148,
    backgroundColor: '#F2F2F2',
  },  

  containerLoginConfirmPressed: {
    marginLeft: '31%',
    marginTop: '5%',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#CB3D44',
    borderRadius: 40,
    height: 56,
    width: 148,
    backgroundColor: '#CB3D49',
  },  
  
  loginConfirmText: {
    fontStyle: 'normal',
    marginTop: '8%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#B3B3B3',
  }, 

  loginConfirmTextPressed: {
    fontStyle: 'normal',
    marginTop: '8%',
    fontWeight: '600',
    fontSize: 22,
    lineHeight: 24,
    color: '#F2F2F2',
  }, 

});
