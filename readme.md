Language Detection API CSharp Client 
========

Detects language of given text. Returns detected language codes and scores.

## Installation

1.  Create an account at loque.la http://loque.la/signup/ And get your api key
2.  Copy loquela.cs in your project
3.  Include the class in your project.

## Usage

### Single Language detection
    var l = new loquela("YOUR-API-KEY");
    var r = l.Detect("Welcome to this language project.");

### Multiple Languages detection
    var l = new loquela("YOUR-API-KEY");

    var unknownTexts = new List<string>();
    unknownTexts.Add("If we have no peace, it is because we have forgotten that we belong to each other." );
    unknownTexts.Add("Be faithful in small things because it is in them that your strength lies.");
    var rs = l.Detect( unknownTexts );

### Multiple Languages detection
    var l = new loquela("YOUR-API-KEY");
    var s = l.Status();
                                 
### Results
#### Detections
    (object) {
    ->data (object) {
        ->detections (array(1)) {
            ['0'] (array(1)) {
                ['0'] (object) {
                    ->language (string) = "en"
                    ->confidence (double) = 1
            }
          }
        }
      }
    }

#### Status
    (object) {
    ->requests (string) = "140"
    ->bytes (string) = "18443"
    }

#### Error
    (object) {
    ->data (object) {
        ->detections (array(1)) {
            ['0'] (object) {
                ->error (object) {
                ->code (integer) = 3
                ->message (string) = "Daily limit reached."
            }
          }
        }
      }
    }

## License
This is free software, and may be redistributed as you please as long as you include this readme file.

[![Bitdeli Badge](https://d2weczhvl823v0.cloudfront.net/FFMG/loquela-csharp/trend.png)](https://bitdeli.com/free "Bitdeli Badge")
