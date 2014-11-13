

from suds.client import Client

c = Client("http://luka.sh/fortune/tools/soap.php?WSDL&readable")

print(c.service.getFortuneStr('debian'))
