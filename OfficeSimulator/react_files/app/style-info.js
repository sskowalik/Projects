import { StyleSheet } from 'react-native';
export const styles_info = StyleSheet.create({
  container: {
    flexDirection: 'column',
    backgroundColor: '#FFFFFF',
  },    
  containerTopBar: {
    flexDirection: 'row',
    alignItems: 'center',
    backgroundColor: '#F2F2F2',
    height: 70,
  },  
  herbPolski: {
    width: 51,
    height: 60,
    marginLeft: '25%',
    marginTop: '1%',
    marginRight:'0%',
    paddingRight: '0%',
  },
  urzedasPl: {
    marginTop: '1%',
    marginLeft: '5%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 30,
    lineHeight: 48,
    color: '#000000',
  },
  lineTop: {
    borderWidth: 1,
    borderColor: '#B3B3B3',
  },
  containerMid: {
    height:605,
    backgroundColor: '#FFFFFF',
    
  },
  Header: {
    marginLeft: '15%',
    marginTop: '10%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 36,
    color: '#656575',
  },
  Text: {
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
  TextName: {
    marginLeft: '8%',
    marginTop: '4%',
    fontStyle: 'normal',
    fontWeight: '600',
    fontSize: 18,
    lineHeight: 20,
    color: '#B3B3B3',
    textAlign: 'justify',
    width: 325,
  },
});
