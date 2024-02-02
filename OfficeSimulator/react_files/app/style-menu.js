import { StyleSheet } from 'react-native';
export const styles_menu = StyleSheet.create({
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
    marginLeft: '16%',
    marginTop: '1%',
  },
  urzedasPl: {
    marginTop: '1%',
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
  containerBodyTiles: {
    flexDirection: 'column',
    height: 604,
  },  
  containerBodyTiles2: {
    flexDirection: 'row',
  },  
  containerBody: {
    marginLeft: '4%',
    marginTop: '4%',
    flexDirection: 'row',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    height: 180,
    width: 360,
  },
  containerBody2: {
    marginLeft: '4%',
    marginTop: '4%',
    flexDirection: 'column',
    justifyContent: 'center',
    alignItems: 'center',
    borderWidth: 5,
    borderColor: '#D6D6D6',
    height: 180,
    width: 172,
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

  notificationBell: {
    marginLeft: '2%',
    marginTop: '1%',
    width: 50,
    height: 50,
    padding: 0,
  },

  icon: {
    marginTop: '4%',
    width: 100,
    height: 100,
    padding: 0,
  },

  iconPlanner: {
    marginLeft: '4%',
    marginTop: '4%',
    width: 140,
    height: 140,
    padding: 0,
  },

  text: {
    marginTop: '4%',
    fontSize: 24,
    lineHeight: 26,
    fontWeight: '600',
    color: '#4D4D4C',
    textAlign: 'center',
  },
  
  textPlanner: {
    marginTop: '4%',
    marginLeft: '10%',
    fontSize: 34,
    lineHeight: 36,
    fontWeight: '600',
    color: '#4D4D4C',
    textAlign: 'center',
  },
});
