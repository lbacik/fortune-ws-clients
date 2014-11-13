<?php
/**
 * @service FortuneSrvSoapClient
 */
class FortuneSrvSoapClient{
	/**
	 * The WSDL URI
	 *
	 * @var string
	 */
	public static $_WsdlUri='http://luka.sh/fortune/tools/soap.php?WSDL';
	/**
	 * The PHP SoapClient object
	 *
	 * @var object
	 */
	public static $_Server=null;

	/**
	 * Send a SOAP request to the server
	 *
	 * @param string $method The method name
	 * @param array $param The parameters
	 * @return mixed The server response
	 */
	public static function _Call($method,$param){
		if(is_null(self::$_Server))
			self::$_Server=new SoapClient(self::$_WsdlUri);
		return self::$_Server->__soapCall($method,$param);
	}

	/**
	 * @param string $path
	 * @return string
	 */
	public function getFortuneHtml($path){
		return self::_Call('getFortuneHtml',Array(
			$path
		));
	}

	/**
	 * @param string $path
	 * @return string
	 */
	public function getFortuneStr($path){
		return self::_Call('getFortuneStr',Array(
			$path
		));
	}
}