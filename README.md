## Oh Hi ##
[![Current Release](https://img.shields.io/github/v/release/mattpannella/pocket_core_autoupdate_net?label=Current%20Release)](https://github.com/mattpannella/pocket_core_autoupdate_net/releases/latest) ![Downloads](https://img.shields.io/github/downloads/mattpannella/pocket_core_autoupdate_net/latest/total?label=Downloads)

A free utility for updating the openFPGA cores, and firmware, on your Analogue Pocket. 
The update process will check for pocket firmware updates, openfpga core updates, and install any required BIOS files and arcade ROMS. You're on your own when it comes to console ROMs. 


A complete list of available cores can also be found here: https://joshcampbell191.github.io/openfpga-cores-inventory/analogue-pocket


## Instructions ##
To run the updater, all you need to do is put the executable file for your platform (windows, mac os, or linux) in the root of your sd card and run the program.

#### Advanced Usage
The updater currently accepts 2 command line parameters. I will probably add more options in the future
```
 -p, --path      Absolute path to install location
 -a, --all       Extract all release assets, instead of just ones containing openFPGA cores.
```
example:
`
/path/to/pocket_updater -u -p /path/to/sdcard/
`

#### Disabling Cores
You can edit your `pocket_updater_settings.json` file and set the `skip` flag to true for any core you don't want to be updated. It won't remove anything from your sd installs, it just skips that core during the update process

#### Github Personal Access Token
If you're running up against the rate limit on the github api, you can provide your personal access token to the updater via the settings.
Edit your local copy of `pocket_updater_settings.json` and put your token in config>github_token

## Submitting new cores ##
You can submit new cores here https://github.com/joshcampbell191/openfpga-cores-inventory

## Credits ##
This is a port of the work initially done by [neil-morrison44](https://github.com/neil-morrison44) here https://gist.github.com/neil-morrison44/34fbb18de90cd9a32ca5bdafb2a812b8 with a few tweaks to suit my needs

Special thanks to [RetroDriven](https://github.com/RetroDriven/) for maintaining the arcade rom archive
