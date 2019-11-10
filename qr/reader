import zbarlight as zb import os import sys import PIL import time 
aux = 0 codigo_actual = 0 
while(True): 
print 'Capturando Imagen' try: 
f = 1 qr_count = len(os.listdir('qr_codes')) print qr_count os.system('sudo raspistill -n -o /home/pi/Documents/QR_Robotica1/qr_codes/qr_'+str(qr_count)+'.jpg') 
print 'Imagen Capturada' except: f = 0 print 'Imagen No Pudo Ser Capturada' 
if(f): # Si conseguimos una imagen 
print 'Buscando Codigo QR' f = open('/home/pi/Documents/QR_Robotica1/qr_codes/qr_'+str(qr_count)+'.jpg','rb') 
qr = PIL.Image.open(f); qr.load() 
codes = zb.scan_codes('qrcode',qr) #buscamos codigos QR en la imagen if(codes==None): 
os.remove('qr_codes/qr_'+str(qr_count)+'.jpg') print 'No se encontro un codigo QR' else: 
print 'Codigo(s) QR:' print codes[0] 
codigo_actual = codes[0] 
f = open('qr_code_messages.txt','a') for i in range(len(codes)): 
f.write(codes[i]) if(i!=len(codes)-1): 
f.write('^') 
f.write('~') 
if(codigo_actual == 'tomate'): 
aux = 1 elif(codigo_actual == 'lechuga'): 
aux = 2 elif(codigo_actual == 'soja'): 
aux = 3 else: 
aux = 0 
f = open('qr_code_which.txt', 'w') f.write(str(aux)) 
CODIGOS PARA EL ACCIONAMIENTO DE LOS MOTORES 
import RPi.GPIO as GPIO from time import sleep 
GPIO.setmode(GPIO.BCM) GPIO.setwarnings(False) 
MotorTomate = 16 MotorLechuga = 18 MotorSoja = 22 
GPIO.cleanup() 
aux = 0 
cual = 0 
GPIO.setup(MotorTomate , GPIO.OUT) GPIO.setup(MotorLechuga , GPIO.OUT) GPIO.setup(MotorSoja , GPIO.OUT) GPIO.setup(27,GPIO.OUT) GPIO.setup(23,GPIO.OUT) GPIO.setup(25,GPIO.OUT) 
GPIO.output(27,GPIO.HIGH) GPIO.output(23,GPIO.HIGH) GPIO.output(25,GPIO.HIGH) 
while(1): 
f = open('qr_code_which.txt', 'r') aux = int(f.read()) 
print aux 
if(aux == 1): 
GPIO.output(16,GPIO.HIGH) print 'tomate' sleep(1) GPIO.output(16,GPIO.LOW) sleep(2) elif(aux == 2): 
GPIO.output(18, GPIO.HIGH) print 'lechuga' sleep(1) GPIO.output(18,GPIO.LOW) sleep(2) elif(aux == 3): 
GPIO.output(22,GPIO.HIGH) sleep(1) GPIO.output(22,GPIO.LOW) print 'soja' sleep(2) else: 
sleep(2) 
