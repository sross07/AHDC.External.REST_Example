AHDC.External.REST_Example
==========================

Written by Scott Ross
Cornell Univeristy 2013

This project covers instructions for external systems to use the API’s developed to 
support online ordering and resulting. This is guide for steps to sign up for test 
and production accounts on the online application.  

Webservice Definitions are found:
https://secure.vet.cornell.edu/ahdc_external_test/metadata
 
Laborder (http verb post):
https://secure.vet.cornell.edu/ahdc_external_test/xml/metadata?op=Result

Labreport (http verb get):
https://secure.vet.cornell.edu/ahdc_external_test/xml/metadata?op=LabReport

ResultPoll (http verb get):
https://secure.vet.cornell.edu/ahdc_external_test/xml/metadata?op=ResultPoll

•	first time use send a 0
•	after first time, send the UID received in the previous usage.

Result  (http verb get):
https://secure.vet.cornell.edu/ahdc_external_test/xml/metadata?op=Result

•	use this as a “pull” method for individual result

When you are ready for production, the URL will change.
Please communication with VMIT to get the new URL.
