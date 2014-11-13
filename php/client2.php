<?php

$c = new SoapClient('http://luka.sh/fortune/tools/soap.php?WSDL');
echo $c->__call('getFortuneStr', array('debian'));

