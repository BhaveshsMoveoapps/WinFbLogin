import React from 'react';
import {
  NativeModules,
} from 'react-native';

class RNWinFbLogin {
  static startLogin(){
      return new Promise((resolve, reject) => {
      NativeModules.RNWinFbLogin.login((e) => {
        return reject({ error: e });
      },(e) => {
        return resolve(e);
      });
    });
  }
}

module.exports = RNWinFbLogin;