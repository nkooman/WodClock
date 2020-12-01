import { StatusBar } from 'expo-status-bar';
import React, { useState } from 'react';
import {
  StyleSheet,
  Text,
  View,
  Button
} from 'react-native';
import * as signalR from '@microsoft/signalr';
import { fromEventPattern } from 'rxjs';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center'
  }
});

const connection = new signalR.HubConnectionBuilder().withUrl('https://localhost:5001/clock-hub').build();
const [ms, setMs] = useState(0);

const registerReceiveTimerHandler = connection.on('ReceiveTimer', setMs);
const unregisterReceiveTimerHandler = connection.off('ReceiveTimer');

const receiveTimerObservable = fromEventPattern<number>(
  () => registerReceiveTimerHandler,
  () => unregisterReceiveTimerHandler
);

// eslint-disable-next-line @typescript-eslint/no-unused-vars
const receiveTimerSubscription = receiveTimerObservable.subscribe();

const sendTimer = (value: number): Promise<unknown> => connection.invoke('SendTimer', value);

export default function App(): JSX.Element {
  return (
    <View style={styles.container}>
      <Text>Open up App.tsx to start working on your app!</Text>
      {/* StatusBar has the prop "style" that is different than the regular prop style on elements. */}
      {/* eslint-disable-next-line react/style-prop-object */}
      <StatusBar style="auto" />
      <Button title="Send Timer" onPress={() => sendTimer}>
        Send Timer
      </Button>
      <Text>{ms}</Text>
    </View>
  );
}
