import React, { useEffect, useState } from 'react';
import { View, Text, TouchableOpacity, Dimensions, ScrollView, TextInput,  ImageBackground, Image} from 'react-native';
import MapView, { Marker, Callout } from 'react-native-maps';
import { styles_menu } from './style-menu';
import { styles_map } from './style-map';
import locationsData from './locations.json'; 
import { useNavigation } from '@react-navigation/native';

const Offices = () => {
    const [locations, setLocations] = useState([]);
    const navigation = useNavigation();

    useEffect(() => {
        setLocations(locationsData);
    }, []);


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
                <Text style={styles_map.visittext2}>Wyszukaj informacje o urzędach! </Text>
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
            <Callout>
              <View style={styles_map.calloutContainer}>
                <Text style={styles_map.calloutText}>{location.name}</Text>
                <Text>{location.address} {location.postal_code}</Text>
                <Text>tel. {location.phone_number}</Text>
                <Text>{location.email}</Text>
                <TouchableOpacity
                  style={styles_map.chooseButton}
                >
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

export default Offices;