# Bertuzzi.MAUI.BehaviorValidationPack

 Package with multiple field validations for MAUI.
 
 Easily validate numbers, texts and implement masks.
 
###### This is the component, works on iOS, Android and UWP.

**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|Xamarin.Forms.BehaviorValidationPack|[![NuGet](https://img.shields.io/badge/nuget-1.0.1-blue.svg)](https://www.nuget.org/packages/Bertuzzi.MAUI.BehaviorValidationPack/)|


**Platform Support**

Bertuzzi.MAUI.BehaviorValidationPack is a MAUI library.
## Setup / Usage

Does not require additional configuration. Just install the package in the shared project and use.

You just need to add the reference in your xaml file.

```csharp
    xmlns:behaviorPack="clr-namespace:Bertuzzi.MAUI.BehaviorValidationPack;assembly=XBertuzzi.MAUI.BehaviorValidationPack"
```

Behavior


```csharp

        <Label Text="Date" FontSize="Small" />
        <DatePicker >
            <DatePicker.Behaviors>
                <behaviorPack:DateValidationBehavior/>
                <behaviorPack:MaskedBehavior Mask="XX/XX/XXXX" />
            </DatePicker.Behaviors>
        </DatePicker>
        
         <Label Text="Age" FontSize="Small" />
        <Entry Placeholder="Age" FontSize="Small">
            <Entry.Behaviors>
                <behaviorPack:MaxLengthValidationBehavior  MaxLength="2"/>
                <behaviorPack:NumberValidationBehavior/>
            </Entry.Behaviors>
        </Entry>

```

**Available Behaviors**

Global Validators

* DateValidationBehavior : Checks if an Date is valid.
* EmailValidationBehavior : Checks if an email is valid.
* MaxLengthValidationBehavior : Limits a Entry with a maximum number of characters.
* NumberValidationBehavior : Valid if a Entry is numeric.
* PasswordValidationBehavior : Validate the strength of a password:
    at least 8 characters
    at least 1 numeric character
    at least 1 lowercase letter
    at least 1 uppercase letter
    at least 1 special character
 
 
Brazilians Validators

* CEPValidationBehavior : Checks if an CEP is valid.
* CNPJValidationBehavior : Checks if an CNPJ is valid.
* CPFValidationBehavior : Checks if an CPF is valid.
* CPFCNPJValidationBehavior : Checks if an CPF or CNPJ is valid.

Masks

* MaskedBehavior : Creates a custom mask on an entry.


```csharp
   <behaviorPack:MaskedBehavior Mask="XX/XX/XXXX" />
```
    

The complete example can be downloaded here: <https://github.com/TBertuzzi/Xamarin.Forms.BehaviorValidationPack/tree/master/MAUIBehaviorValidationPackSample>

based on my package : https://github.com/TBertuzzi/Xamarin.Forms.BehaviorValidationPack
