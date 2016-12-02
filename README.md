
# Rotux Private Server Tutorial
`https://github.com/ossimc82/fabiano-swagger-of-doom`

## 1. Install Mono
*Run this command in terminal:

`sudo apt-get install mono-complete`

## 2. Install XAMPP
* Run this commands in terminal:

`sudo add-apt-repository ppa:upubuntu-com/web`
`sudo apt-get update`
`sudo apt-get install xampp`

## 3. Build the server
Run this command in terminal (at Rotux):

`sudo bash script/build.sh`

## 4. Setup database
* Type in this commmand:

`sudo /opt/lampp/lampp startmysql`

* Then run HeidiSQL or any other SQL Database manager.

* Import Rotux/server/db/database.sql

## 5. Start the server
* Run this command in terminal (at Rotux):

`sudo bash script/run.sh`

* If you want to run only the server (without client):

`sudo bash script/server-only.sh`

## 6. Stop the server
* Close the terminal windows.
