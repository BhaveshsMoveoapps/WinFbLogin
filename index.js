import React from 'react';
import {
  NativeModules,
  Platform
} from 'react-native';

class RNWinFbLogin {
 
  static startLogin(){
    if (Platform.OS === "ios" || Platform.OS === "android") {
      return new Promise((resolve, reject) => {
        NativeModules.RNWinFbLogin.login((e) => {
          return reject({ error: e });
        },(e) => {
          return resolve(e);
        });
      });
    } else {
      NativeModules.RNWinFbLogin.login((e) => {
        return reject({ error: e });
      },(e) => {
        return resolve(e);
      });
    }
  }
}

module.exports = RNWinFbLogin;