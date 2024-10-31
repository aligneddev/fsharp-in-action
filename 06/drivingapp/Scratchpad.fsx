// Referencing programs from scripts
// #load "Car.fs"
// let result = Car.drive 10 8

#r "bin/debug/net8.0/drivingapp.dll"
let result = Car.drive 10 8
