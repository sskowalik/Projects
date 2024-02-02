import { StyleSheet } from 'react-native';
export const styles_map = StyleSheet.create({
    containerText:{
      height:250,
      backgroundColor: '#FFFFFF',
    },
    visittext:{
      marginTop: '5%',
      marginLeft: '5%',
      fontStyle: 'normal',
      fontWeight: '600',
      fontSize: 30,
      lineHeight: 40,
      color: '#000000',
    },
    visittext1:{
      marginLeft: '5%',
      marginTop: '5%',
      fontStyle: 'normal',
      fontWeight: '600',
      fontSize: 18,
      lineHeight: 20,
      color: '#B3B3B3',
      textAlign: 'center',
    },
    visittext2:{
        marginTop: '20%',
        marginLeft: '5%',
        fontStyle: 'normal',
        fontWeight: '600',
        fontSize: 30,
        lineHeight: 40,
        color: '#000000',
        textAlign: 'center',
      },
    container: {
      flexDirection: 'column',
      flex: 1,
    },
    map: {
      flex: 1,
    },
    calloutContainer: {
      width: 200,
    },
    calloutText: {
      fontWeight: 'bold',
      marginBottom: 5,
    },
    chooseButton: {
      marginTop: 10,
      backgroundColor: 'red',
      padding: 10,
      borderRadius: 5,
    },
    chooseButtonText: {
      color: 'white',
    },
    chooseButtonText:{
      textAlign: 'center',
    },
  });