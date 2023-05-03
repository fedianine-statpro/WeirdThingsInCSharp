
# All the weird things I found while working on .NET projects

## ArrayInAppSettingsTest


This project demonstrates that sometimes, despite specifying a particular configuration file in Program.cs, the system may still read configuration values from an unlisted file, leading to unexpected results.

## JsonSerialization


This project demonstrates that when assigning a variable from a derived class to a base class, certain serializers may still treat and serialize the variable as though it belongs to the derived class.
