
# react-native-win-fb-login

## Getting started

`$ npm install react-native-win-fb-login --save`

### Mostly automatic installation

`$ react-native link react-native-win-fb-login`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-win-fb-login` and add `RNWinFbLogin.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNWinFbLogin.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNWinFbLoginPackage;` to the imports at the top of the file
  - Add `new RNWinFbLoginPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-win-fb-login'
  	project(':react-native-win-fb-login').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-win-fb-login/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-win-fb-login')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNWinFbLogin.sln` in `node_modules/react-native-win-fb-login/windows/RNWinFbLogin.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Win.Fb.Login.RNWinFbLogin;` to the usings at the top of the file
  - Add `new RNWinFbLoginPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNWinFbLogin from 'react-native-win-fb-login';

// TODO: What to do with the module?
RNWinFbLogin;
```
  