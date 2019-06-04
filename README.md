# HyperScanning [VR App]

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](http://empathiccomputing.org/)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://github.com/prasanthsasikumar/localMultiplayer)

This project explores how Virtual Reality(VR) can be used to help people understand each other better in face-to-face and remote collaboration, with the ultimate goal of designing an empathic computing interface.  Simultaneous and classification of data from multiple physiological sensors will be carried out to study inter-brain synchrony cognitive load and emotional responses of two or more collaborators in real and virtual environments.


This section explains the implementation of VR set up used. We used two mobile phones( one plus 3 and galaxy S8) for the experiment. The VR app made use of cardboard API to work in VR mode. Both the devices were synced over the internet and we used a computer to obtain a third person view. 


# REQUIREMENTS
- Any mobile VR viewing device supporting google cardboard API.
- We have used Nolo Controllers as input devices.
- For real-time remote collaboration, we incorporated Photon Unity Networking.
- We have used Unity 2019.1.1f1, but should be backwards compatible. 

# TECHNICAL SPECIFICATIONS

### Building
- Android - Select Android from the build settings menu, details in the player settings would already be filled out. Select device, press build and run. 
- Windows/PC/Mac - Select the appropriate option from the menu, click switch platform, It might take about 10 minutes to convert files. Run. This is for the third person view. Hence run this program after both the mobile VR devices have connected.  

### Structure
- Main scene name - MarksOfficePhoton

###### Explanation of Components: 
- Spawn Points(1,2,3) - 2 player spawn points and 1 third person viewer spawn point. 
- NetworkManagerPhoton - The script manages the networking side of things. You can pass on spawn points and player prefab names. The player prefabs have to be kept in the Asset/Resources folder. (Requirement from Photon).
- NoloManager - Takes care of the controllers. There is a development app key that is already keyed in. In case you want to make your own project, it is - 4e4f4c4f484f4d457eff82725bc694a5(Otherwise it won't work). A camera needs to be assigned to the manager script which in our case is done by a script in the player prefab. 
- Room - The environment. (Horrible rendition of Marks room at ECL, ABI)

### Interaction
- Double tap the menu button to orient the view.
- Use trigger to change the player.

### Downloads(Source code)
- Please find the source code here - https://github.com/prasanthsasikumar/localMultiplayer
- Issues can be reported here - https://github.com/prasanthsasikumar/localMultiplayer/issues/new



### Todos

 - Add test cases
 - A lot more work

License
----

MIT


**Free Software, Hell Yeah!**

