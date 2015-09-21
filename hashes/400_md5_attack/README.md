Name:

	md5_attack

Score:

	400

Subject:

	Hashes

Description:

	<?php
	if (md5($code) == md5('240610708') && $code != '240610708'){
		print $flag;
		exit();
	}
	?>

Answer:

	QNKCDZO

Author:

	[life] by_sm

Solve by author:

* This is collision
* Flag is QNKCDZO
