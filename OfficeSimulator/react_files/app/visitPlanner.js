import React, { useEffect, useState } from 'react';
import { View, Text, TouchableOpacity, Dimensions, Alert, ScrollView, TextInput,  ImageBackground, Image} from 'react-native';
import MapView, { Marker, Callout } from 'react-native-maps';
import { styles_menu } from './style-menu';
import { styles_map } from './style-map';
import locationsData from './locations.json'; 
import { useNavigation, useRoute } from '@react-navigation/native';

const VisitPlanner = () => {
  const [locations, setLocations] = useState([]);
  const navigation = useNavigation();
  const route = useRoute();
  const { userData, email} = route.params;
  const [dataAcc, setdataAcc] = useState(null); // Stan przechowujący dane użytkownika
  
  useEffect(() => {
      setdataAcc(JSON.stringify(userData["data"]["user_id"]));
  }, [userData]);

  useEffect(() => {
    setLocations(locationsData);
  }, []);

  const handleMarkerPress = (index) => {
    Alert.alert('Wybrałeś urząd:', locations[index].name);
    const name = locations[index].name;
    const office_id = locations[index].office_id;
    navigation.navigate('reservation', { name, office_id, dataAcc, email });
  };

  const notificationPress = () => {
    navigation.navigate('notifications');
};

  const screenHeight = Dimensions.get('window').height;
  const halfScreenHeight = screenHeight / 2;

  return (
    <View style={styles_map.container}>
        <View style={styles_menu.containerTopBar}>
          <Image source={require('react_files/app/images/herb_Polski.png')} style={styles_menu.herbPolski} />
          <Text style={styles_menu.urzedasPl}>URZĘDAS.PL</Text>
          <TouchableOpacity onPress={notificationPress}>
            <Image source={require('react_files/app/images/notificationBell.png')} style={styles_menu.notificationBell} />
          </TouchableOpacity>
          </View>
          <View style={styles_menu.lineTop}></View>

          <View style={styles_map.containerText}>
                <Text style={styles_map.visittext}>Zarezerwuj wizytę w wybranym przez ciebie urzędzie! </Text>
                <Text style={styles_map.visittext1}> Kliknij na lokalizację urzędu, do którego </Text>
                <Text style={styles_map.visittext1}> chcesz się zgłosić!</Text>
         </View>

      <MapView
        style={{ ...styles_map.map, height: halfScreenHeight }}
        initialRegion={{
          latitude: 50.05427094301187,
          longitude: 19.935413510809216,
          latitudeDelta: 0.083,
          longitudeDelta: 0.083,
        }}
      >
        {locations.map((location, index) => (
          <Marker
            key={index}
            coordinate={{
              latitude: parseFloat(location.latitude),
              longitude: parseFloat(location.longitude),
            }}
          >
            <Callout onPress={() => handleMarkerPress(index)}>
              <View style={styles_map.calloutContainer}>
                <Text style={styles_map.calloutText}>{location.name}</Text>
                <Text>{location.address} {location.postal_code}</Text>
                <Text>tel. {location.phone_number}</Text>
                <Text>{location.email}</Text>
                <TouchableOpacity
                  style={styles_map.chooseButton}
                  onPress={() => handleMarkerPress(index)}
                >
                  <Text style={styles_map.chooseButtonText}>Wybierz urząd!</Text>
                </TouchableOpacity>
              </View>
            </Callout>
          </Marker>
        ))}
      </MapView>
             <View style={styles_menu.containerBottomBar}>
                <Image source={require('react_files/app/images/COI.png')} style={styles_menu.coi} />
                <Image source={require('react_files/app/images/ministerstwo_cyfryzacji.png')} style={styles_menu.mc} />
                <Text style={styles_menu.versionText}>wersja 1.0</Text>
            </View>
    </View>
  );
};

export default VisitPlanner;